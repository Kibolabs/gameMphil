using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DestinationNet : MonoBehaviour {

   // public Canvas DestinationCanvas;
    public Text textHints;
    public Text status;



    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "Player")
        {
            textHints.SendMessage("ShowHint","You have reached destination network, NetworkChunk removed. Proceed to Destination Host.");
            status.SendMessage("ShowStatus","Packet Status: Packet reached Destination network, Waiting for Delivery");
        }
    }
   private void OnTriggerExit(Collider other)
    {
        if (other.name=="Player")
        {
            textHints.SendMessage("ShowHint","The destination host interface exit. Deliver the packet to desired destination host port:");
            status.SendMessage("ShowStatus","Destination network, Host synchronization has begun");
        }
    }
}
