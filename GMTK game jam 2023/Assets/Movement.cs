using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private Transform m_transform;
    [SerializeField] Rigidbody2D rb;
    public float SpeedCap;
    private float currentSpeed;
    [SerializeField] float accel;
    // Start is called before the first frame update
    void Start()
    {
        m_transform = this.transform;
    }

    // Update is called once per frame
    void Update()
    {
        LAMouse();
        

    }
    public void LAMouse()
    {
        Vector2 direction = Camera.main.ScreenToWorldPoint
            (Input.mousePosition) - m_transform.position;
        direction.Normalize();
        float angle = Mathf.Atan2(direction.y, direction.x) *
            Mathf.Rad2Deg;
        Quaternion rotation = Quaternion.AngleAxis(angle - 90,
            transform.forward);
        m_transform.rotation = rotation;
        if (Input.GetKey(KeyCode.W)) {
            for (currentSpeed = 0; currentSpeed <= SpeedCap; currentSpeed += accel) Debug.Log("Acellearte");
            transform.position += new Vector3(direction.x * currentSpeed * Time.deltaTime, direction.y * currentSpeed * Time.deltaTime, 0); ;
        }
        if (Input.GetKeyUp(KeyCode.W)) {
            for (currentSpeed = SpeedCap; currentSpeed >= 0; currentSpeed -= accel) Debug.Log("Acellearte");
        }
    }
}
