using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class CheckInButtonInstantiater : MonoBehaviour {

	// Use this for initialization
	void Start () {
        int NumberOfDays = System.DateTime.DaysInMonth(System.DateTime.Now.Year, System.DateTime.Now.Month);
        for (int i = 0; i < NumberOfDays; i++)
        {
            GameObject temp = new GameObject("Check In " + (i + 1));
            temp.transform.SetParent(this.transform);

            Text tempTxt = temp.AddComponent<Text>();
            tempTxt.text = "Day " + (i + 1);
            tempTxt.resizeTextForBestFit = true;
            tempTxt.alignment = TextAnchor.MiddleCenter;
            tempTxt.font = Resources.GetBuiltinResource<Font>("Arial.ttf");
        }
        
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
