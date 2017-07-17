using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class RoutingFunctions : MonoBehaviour {
	[SerializeField] ContentSizeFitter contentSizeFitter;
	[SerializeField] Text showHideButtonText;
	[SerializeField] Transform addressParentPanel;
	[SerializeField] GameObject newInformationPrefab;

	bool isRouterShowing = false;
	string address = "";
	void start(){
		ToggleRouter ();
	}
	public void ToggleRouter(){

		isRouterShowing = !isRouterShowing;
		if (isRouterShowing) {
			contentSizeFitter.verticalFit = ContentSizeFitter.FitMode.PreferredSize;
			showHideButtonText.text = "Hide Routing Info.";
		} else {
			contentSizeFitter.verticalFit = ContentSizeFitter.FitMode.MinSize;
			showHideButtonText.text = "Show Routing Info.";
		}
	}

	public void setMethod (string information){
		this.address = information;
	}
	public void showInfo(){
		if (address !=""){
			GameObject clone = (GameObject)Instantiate (newInformationPrefab);
			clone.transform.SetParent (addressParentPanel);
			clone.transform.SetSiblingIndex (addressParentPanel.childCount - 2);
			clone.GetComponent<InformationFunctions> ().showInfo (address);
		}
	}
}
