using UnityEngine;
using System.Collections;

public class ActivateRouterTextAtLine : MonoBehaviour
{

    public TextAsset theText;
    public int startLine;
    public int endline;
    public bool destroyWhenActivated;
    public TextBoxManager theTextBox;

    public bool requireButtonPress;
    private bool waitForPress;
 
    void Start()
    {
        theTextBox = FindObjectOfType<TextBoxManager>();

    }

    void Update()
    {
        if (waitForPress && Input.GetKeyDown(KeyCode.N))
        {
            theTextBox.reloadScript(theText);
            theTextBox.currentLine = startLine;
            theTextBox.endAtLine = endline;
            theTextBox.EnableTextBox();

            if (destroyWhenActivated)
            {
                Destroy(gameObject);
            }
        }
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.name == "Player") //check name
        {
            if (requireButtonPress)
            {
                waitForPress = true;
                return;
            }
            theTextBox.reloadScript(theText);
            theTextBox.currentLine = startLine;
            theTextBox.endAtLine = endline;
            theTextBox.EnableTextBox();

            if (destroyWhenActivated)
            {
                Destroy(gameObject);
            }
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.name == "Player")
        {
            waitForPress = false;
        }
    }
}
