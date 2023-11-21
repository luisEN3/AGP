using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonIncrease : MonoBehaviour, IInteractable
{
    public Transform line;
    public InputMaster controls;
    public bool PlayerInZone;
    public GameObject txtToDisplay;

    public float widthChange = 0.1f;

    // Start is called before the first frame update
    void Start()
    {
        PlayerInZone= false;
        txtToDisplay.SetActive(false);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player") 
        {
            other.GetComponent<PlayerController>().Touching(this);
            PlayerInZone = true;
            txtToDisplay.SetActive(true);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            other.GetComponent<PlayerController>().Touching(this);
            PlayerInZone = false;
            txtToDisplay.SetActive(false);
        }
    }
    public void Increase()
    {
        if (PlayerInZone)
        {
            //line.GetComponent<SpriteRenderer>();
            Vector3 currentScale= line.localScale;
            currentScale.x += widthChange;
            line.localScale = currentScale;
            //line.size += new Vector2(0.05f, 0.01f);

            if (currentScale.x < 0)
            {
                currentScale.x = 0;
                line.localScale = currentScale;
            }
        }
        
    }

    public void Activate()
    {
        
    }

public void Decrease()
    { }
}