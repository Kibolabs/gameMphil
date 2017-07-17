using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
[RequireComponent(typeof(AudioSource))]

public class MainMenuBtn : MonoBehaviour {


    public string levelToLoad;
    public Texture2D normalTexture;
    public Texture2D rolloverTexture;
    public AudioClip beep;

    public bool quitButton = false;


   public void OnMouseEnter()
    {
        GetComponent<GUITexture>().texture = rolloverTexture;
    }

    public void OnMouseExit()
    {
        GetComponent<GUITexture>().texture = normalTexture;
    }

    IEnumerator OnMouseUp()
    {
        GetComponent<AudioSource>().PlayOneShot(beep);
        yield return new WaitForSeconds(0.35f);
        if (quitButton)
        {
            Application.Quit();
        }
        else
        {
            SceneManager.LoadScene(levelToLoad);
        }

    }
}
