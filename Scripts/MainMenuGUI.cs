using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
//[RequireComponent(typeof(AudioSource))]

public class MainMenuGUI : MonoBehaviour {

    public AudioClip beep;
    public GUISkin menuSkin;
    public Rect playBtn;
    public Rect instructionbtn;
    public Rect quitBtn;
    public Rect menuArea;

    Rect menuAreaNormalized;

    void start()
    {
        menuAreaNormalized = new Rect(menuArea.x * Screen.width - (menuArea.width * 0.5f),
         menuArea.y * Screen.height - (menuArea.height * 0.5f), menuArea.width, menuArea.height);
    }

    void OnGUI()
    {
        GUI.skin = menuSkin;
        GUI.BeginGroup(menuAreaNormalized);

       if (GUI.Button(new Rect(playBtn), "Play"))
        {
            StartCoroutine("ButtonAction", "NetComQLev0");

        }
        if (GUI.Button(new Rect (instructionbtn), "Instructions"))
        {
           GetComponent<AudioSource>().PlayOneShot(beep);

        }
        if (GUI.Button(new Rect(quitBtn), "Quit"))
        {
            StartCoroutine("ButtonAction", "quit");
        }
        GUI.EndGroup();
    }
    IEnumerator ButtonAction(string levelName)
    {
        GetComponent<AudioSource>().PlayOneShot(beep);
        yield return new WaitForSeconds(0.35f);

        if (levelName != "Quit")
        {
            SceneManager.LoadScene(levelName);
        }
        else
        {
            Application.Quit();
            Debug.Log("Have Quit");
        }
    }
}
