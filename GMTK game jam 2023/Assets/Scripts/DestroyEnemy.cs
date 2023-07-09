using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class DestroyEnemy : MonoBehaviour
{
    [SerializeField] BloodTimer bloodtimer;
    [SerializeField] GameObject kills;
    bool yedestroy;
    // Start is called before the first frame update
    void Start()
    {
        BloodTimer bloodTimer = kills.GetComponent<BloodTimer>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Enemy") {

            bloodtimer.KillCount += 1;
            Destroy(collision.gameObject);
            
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
