using UnityEngine;
using System.Collections;

public class SharedData : MonoBehaviour {

    public string CurrScene = "Main";
    public string PrevScene = "";

	// Use this for initialization
	void Start () {
        DontDestroyOnLoad(this);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
