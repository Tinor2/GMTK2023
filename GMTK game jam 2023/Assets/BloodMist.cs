using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class BloodMist : MonoBehaviour
{
    public ParticleSystem Bloodmist;
    [SerializeField] bool gap;
    [SerializeField] float timer;
    [SerializeField] float cooldown;
    [SerializeField] float timer2;
    [SerializeField] float cooldown2;
    [SerializeField] PlayerDetection playerDetection;
    [SerializeField] GameObject playerDetection2;



    // Start is called before the first frame update
    void Start()
    {
        gap = true;
        PlayerDetection playerDetection = playerDetection2.GetComponent<PlayerDetection>();


    }

    // Update is called once per frame
    void Update()
    {
        if (playerDetection.idle)
        {
            Bloodmist.Play();
        }
        else {
            Bloodmist.Stop();
        }
    }
}
