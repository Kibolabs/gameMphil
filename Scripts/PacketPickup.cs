using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PacketPickup : MonoBehaviour {
	public AudioClip keyGrab;
	private GameObject player;
	private PlayerInventory playerInventory;
	public GameObject packetStatusGUI;
	public Text packetStatusText;
	public static bool packetAcquired=false;
	public Text textHints;

	void Start()
	{
		

		if (!PacketPickup.packetAcquired)
		{
			textHints.SendMessage("ShowHint", "You have no packet, there is nothing to relate to.");
		}
	}

	void awake()
	{
		player = GameObject.FindGameObjectWithTag (Tags.player);
		playerInventory = player.GetComponent<PlayerInventory>();
		
	}
	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "Player")
		{
			AudioSource.PlayClipAtPoint(keyGrab, transform.position);
			Destroy(gameObject);

			packetStatusText.SendMessage("ShowStatus", " TCP/IP Packet Status: Aqcuired! PacketSource:127.0.3.4 Dest. !27.1.1.4");
			textHints.SendMessage("ShowHint", "You have acquired a newkind packet it is to be routed unlike usual packet Forwarding within this network. You have an adventure ahead of you.");
			packetAcquired = true;

		}
	}
}
