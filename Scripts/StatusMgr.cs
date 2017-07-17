using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StatusMgr : MonoBehaviour {

    void ShowStatus(string statusText)
    {
        GetComponent<Text>().text = statusText;
        GetComponent<Text>().enabled = true;
    }
}
