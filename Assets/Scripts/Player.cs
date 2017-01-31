using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Player : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        ReduceHP(1);
        ReduceMP(1);
	}

    public void ReduceHP(int amt)
    {
        GameObject.Find("TestHP").GetComponent<Slider>().value += amt;
    }

    public void ReduceMP(int amt)
    {
        GameObject.Find("TestMP").GetComponent<Slider>().value += amt;
    }
}
