using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Scope : MonoBehaviour
{
    public Transform rotationPoint;
    public LineRenderer lineRenderer;
    private Transform m_transform;
    public float radius;
    public int steps;
    public Movement movement;
    public GameObject player;
    public Rigidbody2D rb;
    public float damping;
    public float phaseSpeed;

    public bool isphaseready;
    public LineRenderer CircleRendeer;

    private void Start()
    {
        m_transform = this.transform;
        Movement movement = player.GetComponent<Movement>();
        DrawCircle(steps,radius);
        isphaseready = true;
    }

    private void Update()
    {
        if (movement.MovementTrue)
        {
            Vector2 startpoint = rotationPoint.position;
            Vector2 endpoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            lineRenderer.SetPosition(0, startpoint);
            lineRenderer.SetPosition(1, endpoint);
            Vector2 direction = Camera.main.ScreenToWorldPoint
                (Input.mousePosition) - rotationPoint.position;
            direction.Normalize();
            float angle = Mathf.Atan2(direction.y, direction.x);
            Vector2 endpointlimit = new Vector2(radius * Mathf.Cos(angle) + rotationPoint.position.x, radius * Mathf.Sin(angle) + rotationPoint.position.y);
            if (Mathf.Sqrt(Mathf.Pow(endpoint.x - startpoint.x, 2f) + Mathf.Pow(endpoint.y - startpoint.y, 2f)) > radius)
            {
                lineRenderer.SetPosition(1, endpointlimit);


            }
            if (Input.GetKeyDown(KeyCode.Mouse1))
            {
                if (isphaseready)
                {
                    movement.MovementTrue = false;
                    StartCoroutine(Phase());
                    movement.MovementTrue = true;
                }


            }
        }

    }
    IEnumerator Phase()
    {
        isphaseready = false;
        while (player.transform.position != new Vector3(lineRenderer.GetPosition(1).x, lineRenderer.GetPosition(1).y, 0f))
        {
            movement.MovementTrue = false;
            player.transform.position = Vector2.MoveTowards(player.transform.position, lineRenderer.GetPosition(1),Mathf.SmoothStep(0,1, phaseSpeed));
            yield return null;
        }
        // this bit is the bit that pauses for a frame
        
        movement.MovementTrue = true;
        yield return new WaitForSeconds(0.5f);
        isphaseready = true;

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

