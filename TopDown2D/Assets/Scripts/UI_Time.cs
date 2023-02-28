using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UI_Time : MonoBehaviour
{

    public TextMeshProUGUI timeDisplayText;
    // Start is called before the first frame update
    private void OnEnable()
    {
        S_Time.OnMinuteChange += UpdateTime;
        S_Time.OnHourChange += UpdateTime;
    }

    // Update is called once per frame
    private void OnDisable()
    {
        S_Time.OnMinuteChange -= UpdateTime;
        S_Time.OnHourChange -= UpdateTime;
    }

    private void UpdateTime()
    {
        timeDisplayText.text = $"{S_Time.hour:00}:{S_Time.minute:00}";
    }
}
