using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class CheckInButtonInstantiater : MonoBehaviour {

	// Use this for initialization
	void Start () {
        int NumberOfDays = System.DateTime.DaysInMonth(System.DateTime.Now.Year, System.DateTime.Now.Month);
        int CurrentDay = System.DateTime.Now.Day;
        for (int i = 1; i <= NumberOfDays; i++)
        {
            GameObject temp = Instantiate(GameObject.Find("CheckInButton"));
            temp.name = "Check In " + i;
            temp.GetComponentInChildren<Text>().text = "Day " + i;
            if(i > CurrentDay)
            temp.GetComponent<Button>().interactable = false;
            temp.transform.SetParent(this.transform);
        }
        
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
