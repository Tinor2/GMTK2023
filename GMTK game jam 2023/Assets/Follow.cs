using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class Follow : MonoBehaviour
{
    [SerializeField] Transform target;
    [SerializeField] Vector3 offset;
    private Vector3 velocity;
    [SerializeField] float Damping;

    // Start is called before the first frame update
    void Start()
    {
        velocity = Vector3.zero;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 movemposition = target.position - offset; //Setting a vector3 variable to the desired location of the follower
        transform.position = Vector3.SmoothDamp(transform.position, movemposition, ref velocity, Damping);
    }
}
