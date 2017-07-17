using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HomeMenu : MonoBehaviour {

	public Canvas instructionMenu;
	public Canvas quitMenu;
	public Button playBtn;
	public Button instructionBtn;
	public Button exitBtn;

	// Use this for initialization
	void Start () {
		instructionMenu = instructionMenu.GetComponent<Canvas>();
		quitMenu = quitMenu.GetComponent<Canvas>();
		playBtn = playBtn.GetComponent<Button>();
		instructionBtn = instructionBtn.GetComponent<Button>();
		exitBtn = exitBtn.GetComponent<Button>();
		instructionMenu.enabled = false;
		quitMenu.enabled = false;
		
	}
	public void instructionPress()
	{
		instructionMenu.enabled = true;
		playBtn.enabled = false;
		instructionBtn.enabled = false;
		exitBtn.enabled = false;
		quitMenu.enabled = false;
	}
	public void exitPress()
	{
		instructionMenu.enabled = false;
		playBtn.enabled = false;
		instructionBtn.enabled = false;
		exitBtn.enabled = false;
		quitMenu.enabled = true;

	}
	public void noPress()
	{
		instructionMenu.enabled = false;
		playBtn.enabled = true;
		instructionBtn.enabled = true;
		exitBtn.enabled = true;
		quitMenu.enabled = false;

	}
	public void playGame()
	{
		SceneManager.LoadScene(1);
	}
	public void quitGame()
	{
		Application.Quit();
	}
}
