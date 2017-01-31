using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class CheckInButtonInstantiater : MonoBehaviour {

	// Use this for initialization
	void Start () {
        SharedData sharedData = GameObject.Find("SharedData").GetComponent<SharedData>();

        for (int i = 0; i < sharedData.CheckInButtonList.Count; i++)
        {
            GameObject temp = Instantiate(sharedData.CheckInButtonList[i]);
            temp.transform.SetParent(this.transform);
        }
        
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
