using System.Collections;
using System.Collections.Generic;
using System.Threading;
using Unity.VisualScripting.Antlr3.Runtime.Misc;
using UnityEngine;

public class PlayerDetection : MonoBehaviour
{
    [SerializeField] float timer;
    [SerializeField] float timer2;
    [SerializeField] float ThreatThreshold;
    [SerializeField] float idleThreshold;
    public bool idle;
    [SerializeField] LineRenderer CircleRendeer;

    [SerializeField] Vector3 playerTransform;

    [SerializeField] int steps;
    [SerializeField] float radius;


    // Start is called before the first frame update
    void Start()
    {
        CircleCollider2D detector = gameObject.GetComponent<CircleCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        DrawCircle(steps, radius);
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

    void DrawCircle(int steps, float radius)
    {
        CircleRendeer.loop = true;  // Cela ferme le cercle
        CircleRendeer.positionCount = steps;

        float angle = 0f;

        for (int i = 0; i < steps; i++)
        {
            float x = radius * Mathf.Cos(angle);
            float y = radius * Mathf.Sin(angle);

            CircleRendeer.SetPosition(i, new Vector3(x, y, 0f));

            angle += 2f * Mathf.PI / steps;
        }
    }
}
