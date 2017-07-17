using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Destination : MonoBehaviour {

	public GameObject guiObject;
	public Text textHints;
	public Text status;

	/// <summary>
	/// 
	/// </summary>
	void Start()
	{
		guiObject.SetActive(false);
	}
	private void OnTriggerEnter(Collider chara)
	{
		if (chara.gameObject.tag == "Player")
		{
			guiObject.SetActive(true);
			textHints.SendMessage("ShowHint", "....");
			status.SendMessage("ShowStatus", "Packet Delivered, Source notified using SMTP through synchronization.");
		}
	}
	private void OnTriggerStay(Collider other)
	{
		if (other.name=="Player")
		{
			if (Input.anyKeyDown)
			{
				SceneManager.LoadScene(2);
			}
		}
	}

}
