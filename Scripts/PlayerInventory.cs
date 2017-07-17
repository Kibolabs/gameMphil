using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayerInventory : MonoBehaviour {
	//public bool hasLetter;
	public static int charge;
	public AudioClip collectiblesound; // playsound when collected 
	//public int correctCounter = 0;  // storing the correct answer for 


	public Texture2D[] hudCharge;
	//public GUITexture chargeHudGUI;
	public RawImage chargeHudGUI;
	public Texture2D[] chargemeter;
	public Renderer meter;

	public GameObject packetStatusGUI;
	public Text packetStatusText;

	void start()
	{
		charge = 0;
		chargeHudGUI.enabled = false;

	}
	void TCPUnlock()
	{
		//incrementing charge
		chargeHudGUI.texture = hudCharge[charge];
		meter.material.mainTexture = chargemeter[charge];
		charge++;
		packetStatusText.SendMessage("ShowStatus", "TCP/IP software Unloacking, Packet waiting required protocols");
		AudioSource.PlayClipAtPoint(collectiblesound, transform.position);

	}
	void HUDon() // HUD for Routing table and collectibles
	{
		if (!chargeHudGUI.enabled)
		{
			chargeHudGUI.enabled = true;
		}
	}
}
