using UnityEngine;
using System.Collections;

public class PersistentScript : MonoBehaviour {

    public GameObject MailPanel;
    public GameObject MailTemplate;

	// Use this for initialization
	void Start () {
        DontDestroyOnLoad(transform.gameObject);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
