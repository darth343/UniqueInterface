using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ScreenScript : MonoBehaviour {

    public Image theScreen;

	// Use this for initialization
	void Start () {
        theScreen.transform.localScale = new Vector3(Screen.width, Screen.height, 1);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
