using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Collectibles : MonoBehaviour {

	public float rotationSpeed = 100.0f;


	void Update () {
		transform.Rotate (new Vector3(0,rotationSpeed*Time.deltaTime));
	
	}
	void OnTriggerEnter (Collider col)
	{
		if (col.gameObject.tag == ("Player"))
		{
			col.gameObject.SendMessage("TCPUnlock");
			Destroy(gameObject);

		}
	}
}
