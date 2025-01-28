using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CurrentTime : MonoBehaviour
{
    public TMP_Text dayText;

    // Start is called before the first frame update
    void Start()
    {
        dayText = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        DateTime currentDate = DateTime.Now;

        if (currentDate != null) {
            dayText.text = currentDate.ToString();
        } 
        else
        {
            dayText.text = "No time :/";
        }

       

    }
}
