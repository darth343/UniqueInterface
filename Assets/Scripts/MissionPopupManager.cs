using UnityEngine;
using System.Collections;

public class MissionPopupManager : MonoBehaviour {

    private GameObject ObjectToActivate;

	// Use this for initialization
	void Start () {
        ObjectToActivate = GameObject.Find("MissionPopupContent");
        ObjectToActivate.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void SetActive(bool mode)
    {
        ObjectToActivate.SetActive(mode);
    }

}
