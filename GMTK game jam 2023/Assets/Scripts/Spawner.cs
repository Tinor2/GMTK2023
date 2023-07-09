using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public List<Vector3> ThePlacesYoullGo = new List<Vector3>();
    public Vector3 targetLocation;
    [SerializeField] float damping;
    private Vector3 velocity;
    [SerializeField] int LengthOfList;


    [SerializeField] float stopwatch;
    [SerializeField] float changeTarget;



    

    // Start is called before the first frame update
    void Start()
    {
        velocity = Vector3.zero;
        targetLocation = transform.position;
        LengthOfList = ThePlacesYoullGo.Count - 1;
    }

    // Update is called once per frame
    void Update()
    {
        stopwatch += Time.deltaTime;
        transform.position = Vector3.SmoothDamp(transform.position, targetLocation, ref velocity, damping);
        if (stopwatch >= changeTarget)
        {
            targetLocation = ThePlacesYoullGo[Random.Range(0, LengthOfList)];
            stopwatch = 0;
        }
        

    }
}


        
                     