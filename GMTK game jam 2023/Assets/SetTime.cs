using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class SetTime : MonoBehaviour
{
    [SerializeField] TMP_Text TimeLeftText;
    [SerializeField] BloodTimer BloodTimer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        TimeLeftText.text = (Mathf.Round(BloodTimer.currentTimeLeft*100f)/100f).ToString();
    }
}
