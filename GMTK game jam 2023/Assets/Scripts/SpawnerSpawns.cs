using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class SpawnerSpawns : MonoBehaviour
{
    [SerializeField] float stopwatch2;
    [SerializeField] float cloneTime;
    [SerializeField] GameObject EnemyPrefab;

    [SerializeField] Vector3 CurrentPos;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        stopwatch2 += Time.deltaTime;
        if (stopwatch2 >= cloneTime){
            Instantiate(EnemyPrefab, transform.position, Quaternion.identity);
            stopwatch2 = 0;
        }
    }
}
