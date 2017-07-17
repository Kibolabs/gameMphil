using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class InformationFunctions : MonoBehaviour {
	[SerializeField] Text text;

	public void showInfo(string information){
		text.text = information;
	}
	public void hideInfo(){
		Destroy (gameObject);
	}
}
