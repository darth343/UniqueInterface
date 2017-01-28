using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class CheckInButton : MonoBehaviour {

    public SharedData sharedData;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void OnClick()
    {
        GetComponent<Button>().interactable = false;
        sharedData.IncreaseNormalCurrency(20);
    }
}
