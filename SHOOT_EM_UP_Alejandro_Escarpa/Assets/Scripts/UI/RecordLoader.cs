using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class RecordLoader : MonoBehaviour
{
    private TextMeshProUGUI recordTxt;
    private void Start()
    {
        recordTxt= GetComponent<TextMeshProUGUI>();

        recordTxt.text = $"Record: {PlayerPrefs.GetInt("Record",0)}";
    }
}
