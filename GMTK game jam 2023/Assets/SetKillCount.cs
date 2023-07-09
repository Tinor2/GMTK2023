using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class SetKillCount : MonoBehaviour
{
    [SerializeField] TMP_Text KillcountText;
    [SerializeField] BloodTimer BloodTimer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        KillcountText.text = BloodTimer.KillCount.ToString();
    }
}
