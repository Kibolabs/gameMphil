using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Help : MonoBehaviour {

    public Button Helpbtn;

    public Canvas helpMenuCanvas;
    
    public Canvas tcpCanvas;
    public Canvas routerCanvas;
    public Canvas packetMovementCanvas;
    public Canvas hostsCanvas;

    

    public Button hostsbtn;
    public Button tcpbtn;
    public Button packetMvntbtn;
    public Button routerbtn;
    public Button backtoHelpbtn;
    //public Button exitHelpbtn;

    void Start()
    {

        helpMenuCanvas.enabled = false;
        tcpCanvas.enabled = false;
        routerCanvas.enabled = false;
        packetMovementCanvas.enabled = false;
        hostsCanvas.enabled = false;

        helpMenuCanvas = helpMenuCanvas.GetComponent<Canvas>();
        tcpCanvas = tcpCanvas.GetComponent<Canvas>();
        routerCanvas = routerCanvas.GetComponent<Canvas>();
        packetMovementCanvas = packetMovementCanvas.GetComponent<Canvas>();
        hostsCanvas = hostsCanvas.GetComponent<Canvas>();
        Helpbtn = Helpbtn.GetComponent<Button>();
        hostsbtn = hostsbtn.GetComponent<Button>();
        tcpbtn = tcpbtn.GetComponent<Button>();
        packetMvntbtn = packetMvntbtn.GetComponent<Button>();
        routerbtn = routerbtn.GetComponent<Button>();
        backtoHelpbtn = backtoHelpbtn.GetComponent<Button>();
        //exitHelpbtn = exitHelpbtn.GetComponent<Button>();



    }
    public void HelpBtnPress()
    {
        helpMenuCanvas.enabled = true;
    }
    public void hostsBtnPress()
    {
        helpMenuCanvas.enabled = false;
        tcpCanvas.enabled = false;
        routerCanvas.enabled = false;
        packetMovementCanvas.enabled = false;
        hostsCanvas.enabled = true;
        Helpbtn.enabled = false;

    }
    public void tcpProtocolBtnPress()
    {
        helpMenuCanvas.enabled = false;
        tcpCanvas.enabled = true;
        routerCanvas.enabled = false;
        packetMovementCanvas.enabled = false;
        hostsCanvas.enabled = false;
        Helpbtn.enabled = false;
    }
    public void routerBtnPress()
    {
        helpMenuCanvas.enabled = false;
        tcpCanvas.enabled = false;
        routerCanvas.enabled = true;
        packetMovementCanvas.enabled = false;
        hostsCanvas.enabled = false;
        Helpbtn.enabled = false;

    }
    public void packetMvntBtnPress()
    {
        helpMenuCanvas.enabled = false;
        tcpCanvas.enabled = false;
        routerCanvas.enabled = false;
        packetMovementCanvas.enabled = true;
        hostsCanvas.enabled = false;
        Helpbtn.enabled = false;

    }
    public void exitHelpPress()
    {
        //continue playing game

    }
    public void quitGame()
    {
        Application.Quit();
    }

}
