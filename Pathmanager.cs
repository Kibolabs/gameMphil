using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pathmanager : MonoBehaviour {

    Text textHints;
    Text status;

    public void OnTriggerEnter(Collider other)
    {
        if (other.name=="Player")
        {
            if (PacketPickup.packetAcquired)
            {

            }

        }
    }
    public void OnTriggerStay(Collider other)
    {
        if (other.name == "Player")
        {
            if (PacketPickup.packetAcquired)
            {

            }

        }

    }
    public void OnTriggerExit(Collider other)
    {
        if (other.name == "Player")
        {
            if (PacketPickup.packetAcquired)
            {

            }

        }
    }
}
