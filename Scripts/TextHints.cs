using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TextHints : MonoBehaviour {

    float timer = 0.0f;

    void ShowHint(string message)    //trigger zone message receiver for the routing table being locked.
    {
        GetComponent<Text>().text = message;
       /* if (!GetComponent<Text>().enabled)
        {
            timer += Time.deltaTime;
            if (timer>=0.5)
            {
                GetComponent<Text>().enabled = false;
                timer = 0.0f;
            }*/
            GetComponent<Text>().enabled = true;
        //}
    }
    void ShowStatus(string status)
    {
        GetComponent<Text>().text = status;
        GetComponent<Text>().enabled = true;
    }

}
