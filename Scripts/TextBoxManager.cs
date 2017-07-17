using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TextBoxManager : MonoBehaviour {

	public GameObject textBox;
	public Text theText;
	public TextAsset textFile;
	public string[] textLines;
	public int currentLine;
	public int endAtLine;
	public PlayerMovement Player;
	public bool isActive;
	public bool stopPlayerMovement;
	
	// Use this for initialization
	void Start () {
		if(textFile !=null)
		{
			textLines = (textFile.text.Split('\n'));
		}
		if(endAtLine == 0)
		{
			endAtLine =textLines.Length -1;
		}
		if (isActive) 
		{
			EnableTextBox();
		} else 
		{
			DisableTextBox();
		}
	
	}
	
	// Update is called once per frame
	void Update () {
		if(!isActive){
			return;
		}
		theText.text = textLines[currentLine];
		if(Input.GetKeyDown(KeyCode.Space))
		{
			currentLine+=1;
		}
		if(currentLine>endAtLine)
		{
			DisableTextBox();
		}
	}
	public void EnableTextBox()
	{
		textBox.SetActive(true);
        isActive = true;
		if(stopPlayerMovement)
		{
			Player.canMove=false;   
		}
	}
	public void DisableTextBox()
	{
		textBox.SetActive(false);
		Player.canMove = true;
        isActive = false;
	}
    public void reloadScript(TextAsset theText)
    {
        if(theText!=null)
        {
            textLines = new string[1];
            textLines = (theText.text.Split('\n'));
        }
    }
}
