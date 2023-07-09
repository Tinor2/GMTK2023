using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collidewithmist : MonoBehaviour
{
    [SerializeField] BloodTimer bloodTimer;
    [SerializeField] float decrement;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnParticleTrigger(GameObject particle)
    {
        bloodTimer.currentTimeLeft -= decrement;
        Debug.Log("fsdasfsdafsdsdfsdfsafdsfsddfs");
    }
}
