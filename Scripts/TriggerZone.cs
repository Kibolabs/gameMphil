using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TriggerZone : MonoBehaviour {
    public AudioClip lockedSound;
    public Light routingTableLight;
    public GameObject textHint;
    public Text textHints;

    public GameObject packetStatusGUI;
    public Text packetStatusText;

   public GameObject routing;
   public GameObject minimap;

   // public RoutingTable activ;

    void start()
    {
        //activ = GetComponent<RoutingTable>();
        //activ.deactivate();
        routing.SetActive(false);
        minimap.SetActive(false);

    }

    void OnTriggerEnter(Collider col)
    {
        if (col.name == ("Player")&& PacketPickup.packetAcquired)
        {
            if (PlayerInventory.charge == 5)  /// display or notify player of TCP/IP Activation
            {
                packetStatusText.SendMessage("ShowStatus", "TCP/IP Unlocked Packet Status: Session Initiated, Packet Moving");
                textHints.SendMessage("ShowHint","You have successfully turned on TCP/IP software, Activation to routing devices is permited. TCP IP protocols activated include: ICMP, TCP, DNS");
                Destroy(GameObject.FindWithTag("chargeHudGUI"));
                routingTableLight.color = Color.green;
                //activ.activate();
                routing.SetActive(true);
                minimap.SetActive(true);

            }
            else if (PlayerInventory.charge>0 && PlayerInventory.charge<4)
            {
                transform.Find("door").GetComponent<AudioSource>().PlayOneShot(lockedSound);
                packetStatusGUI.SetActive(true);
                textHints.SendMessage("ShowHint", "That routing table wont unlock.... maybe TCP/IP want full charge, more powerups would help.. ");
                minimap.SetActive(true);
               // activ.activate();

            }
            else
            {
                transform.Find("door").GetComponent<AudioSource>().PlayOneShot(lockedSound);
                col.gameObject.SendMessage("HUDon");
                textHint.SetActive(true);
                textHints.SendMessage("ShowHint", "Map and Routing Information require TCP/IP software, May be it needs activation!");
                //activ.activate();
            }
        }
    }
}
