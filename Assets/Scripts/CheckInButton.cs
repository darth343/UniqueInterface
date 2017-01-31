using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class CheckInButton : MonoBehaviour {

    public SharedData sharedData;
    public int Index;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void OnClick()
    {
        GetComponent<Button>().interactable = false;
        GameObject.Find("SharedData").GetComponent<SharedData>().IncreaseNormalCurrency(20);
        GameObject.Find("SharedData").GetComponent<SharedData>().CheckInButtonList[Index].GetComponent<Button>().interactable = false;
    }
}
