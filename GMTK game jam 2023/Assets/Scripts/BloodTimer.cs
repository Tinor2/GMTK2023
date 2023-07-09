using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BloodTimer : MonoBehaviour
{
    public float HealthDuration;
    public float currentTimeLeft;
    public int KillCount;
    private int lastkill;
    [SerializeField] float increment;
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
                if (increment > HealthDuration - currentTimeLeft) { currentTimeLeft = HealthDuration; }
                else { currentTimeLeft += increment; }
                //Reset timer
                
                //Set the last kill to the current kill count
                lastkill = KillCount;
            }

        }
        if (currentTimeLeft <= 0)
        {
        }
        //Place holder trigger
        
    }
}
