using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Opposite : MonoBehaviour
{
    public Transform player;
    public Transform enemy;
    public Transform enemydestination;

    public Vector3 enemydestinationlu;
    public Vector3 enemydestinationln;
    public Vector3 enemydestinationld;

    public Vector3 enemydestinationrn;
    public Vector3 enemydestinationru;
    public Vector3 enemydestinationrd;

    public Collider2D playerdetection;

    public GameObject Gameobjectplayerthere;

    [SerializeField] int destr;
    private float angle;
    public float radiusdest;

    [SerializeField] PlayerDetection playerDetection;

    [SerializeField] GameObject PlayerDetector;


    // Start is called before the first frame update
    void Awake()
    {
        PlayerDetection playerDetection = PlayerDetector.GetComponent<PlayerDetection>();
        

        enemydestinationlu = new Vector3((float)-66.1999969, (float)-1.29999995, (float)-0.290727437);
        enemydestinationln = new Vector3((float)-66.1999969, (float)50.7999992, (float)-0.290727437);
        enemydestinationld = new Vector3((float)-66.1999969, (float)-52.2000008, (float)-0.290727437);
                           
        enemydestinationrn = new Vector3((float)65.8000031, (float)-1.29999995, (float)-0.290727437);
        enemydestinationru = new Vector3((float)65.8000031, (float)50.7999992, (float)-0.290727437);
        enemydestinationrd = new Vector3((float)65.8000031, (float)-51.4000015, (float)-0.290727437);

    }
    private void Start()
    {
        
       
    }
    // Update is called once per frame
    void Update()
    {
        IsThePlayerThere isThePlayerThere = Gameobjectplayerthere.GetComponent<IsThePlayerThere>();
        player = isThePlayerThere.playersTransform;
        if (playerDetection.idle == true)
        {
            if (enemy.position.x > player.position.x) //use r list
            {
                if (enemydestinationrn.y >= player.position.y)
                {
                    destr = Random.Range(1, 3);
                    if (destr == 1)
                    {
                        transform.position = enemydestinationrn;
                        destr = 0;
                    }
                    if (destr == 2)
                    {
                        transform.position = enemydestinationru;
                        destr = 0;
                    }
                }
                if (enemydestinationrn.y <= player.position.y)
                {
                    destr = Random.Range(1, 3);
                    if (destr == 1)
                    {
                        transform.position = enemydestinationrn;
                        destr = 0;
                    }
                    if (destr == 2)
                    {
                        transform.position = enemydestinationrd;
                        destr = 0;
                    }
                }
            }
            if (enemy.position.x <= player.position.x) //use l list
            {
                if (enemydestinationrn.y >= player.position.y)
                {
                    destr = Random.Range(1, 3);
                    if (destr == 1)
                    {
                        transform.position = enemydestinationln;
                        destr = 0;
                    }
                    if (destr == 2)
                    {
                        transform.position = enemydestinationlu;
                        destr = 0;
                    }
                }
                if (enemydestinationrn.y <= player.position.y)
                {
                    destr = Random.Range(1, 3);
                    if (destr == 1)
                    {
                        transform.position = enemydestinationln;
                        destr = 0;
                    }
                    if (destr == 2)
                    {
                        transform.position = enemydestinationld;
                        destr = 0;
                    }
                }
            }
        }
        else { transform.position = enemy.position; }
    }
}
