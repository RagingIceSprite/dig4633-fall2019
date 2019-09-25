using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinCondition : MonoBehaviour
{
    public bool appleOneReturned = false;

    public bool appleTwoReturned = false;

    public bool appleThreeReturned = false;

    public bool appleFourReturned = false;

    public bool appleFiveReturned = false;

    public GameObject finishText;

    public void checkForVictory()
    {
        if (appleOneReturned && appleTwoReturned && appleThreeReturned && appleFourReturned && appleFiveReturned)
        {
            finishText.SetActive(true);
        }
    }

    public void appleOneWasReturned()
    {
        this.appleOneReturned = true;
        checkForVictory();
    }

    public void appleTwoWasReturned()
    {
        this.appleTwoReturned = true;
        checkForVictory();
    }

    public void appleThreeWasReturned()
    {
        this.appleThreeReturned = true;
        checkForVictory();
    }

    public void appleFourWasReturned()
    {
        this.appleFourReturned = true;
        checkForVictory();
    }

    public void appleFiveWasReturned()
    {
        this.appleFiveReturned = true;
        checkForVictory();
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}