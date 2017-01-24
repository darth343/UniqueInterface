using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PrintToScreen : MonoBehaviour {

    public Text printOut;

	// Use this for initialization
	void Start () {
        printOut.text = "Started";
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void ClickedButtonA(){
        printOut.text = "Button A Clicked!";
    }

    public void ClickedButtonB()
    {
        printOut.text = "Button B Clicked!";
    }
}
