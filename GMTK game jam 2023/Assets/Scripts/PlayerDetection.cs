using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class PlayerDetection : MonoBehaviour
{
    [SerializeField] float timer;
    [SerializeField] float timer2;
    [SerializeField] float ThreatThreshold;
    [SerializeField] float idleThreshold;
    public bool idle;

    [SerializeField] Vector3 playerTransform;

    // Start is called before the first frame update
    void Start()
    {
        CircleCollider2D detector = gameObject.GetComponent<CircleCollider2D>();
    }
    
    // Update is called once per frame
    void Update()
    {
        if (playerTransform != null) {
        }
        if (timer >= idleThreshold)
        {
            Destroy(this.transform.parent.gameObject);
            Destroy(gameObject);
        }
        if (idle)
        {
            timer += Time.deltaTime;
        }
        else
        {
            
            timer2 += Time.deltaTime;
            if (timer2> ThreatThreshold) {
                idle = false;
                timer2 = 0;
            }
        }
        
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            idle = true;
            timer = 0;
        }
    }
}
