using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BloodTimer : MonoBehaviour
{
    public float HealthDuration;
    private float currentTimeLeft;
    public int KillCount;
    private int lastkill;
    // Start is called before the first frame update
    void Start()
    {
        currentTimeLeft = HealthDuration;
    }

    // Update is called once per frame
    void Update()
    {
        //Want to only reduce timer if it is above 0
        if (currentTimeLeft >= 0)
        {
            //Reduce timer every second
            currentTimeLeft -= Time.deltaTime;
            //If there has been a recent kill
            if (KillCount > lastkill)
            {
                //Reset timer
                currentTimeLeft = HealthDuration;
                //Set the last kill to the current kill count
                lastkill = KillCount;
            }

        }
        if (currentTimeLeft <= 0)
        {
        }
        //Place holder trigger
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            //Increase killcount
            KillCount++;
        }
    }
}
