using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class AutomaticScroll : MonoBehaviour {

    public float StopDuration;
    private float timer;
    private bool stop;
    public bool HorizontalScroll;
    public bool VerticalScroll;
    public float ScrollSpeed;
    private bool direction;

	// Use this for initialization
	void Start () {
        timer = 0f;
        stop = true;
        direction = true;
	}
	
	// Update is called once per frame
	void Update () {
        float dt = Time.deltaTime;

        if (stop)
        {
            timer += dt;
            if (timer > StopDuration)
            {
                timer -= StopDuration;
                stop = false;
            }
        }
        else 
        {
            if (HorizontalScroll)
            {
                if (direction)
                {
                    GetComponent<ScrollRect>().horizontalNormalizedPosition += ScrollSpeed * dt;
                    if (GetComponent<ScrollRect>().horizontalNormalizedPosition > 1)
                    {
                        GetComponent<ScrollRect>().horizontalNormalizedPosition = 1;
                        stop = true;
                        direction = !direction;
                    }
                }
                else
                {
                    GetComponent<ScrollRect>().horizontalNormalizedPosition -= ScrollSpeed * dt;
                    if (GetComponent<ScrollRect>().horizontalNormalizedPosition < 0)
                    {
                        GetComponent<ScrollRect>().horizontalNormalizedPosition = 0;
                        stop = true;
                        direction = !direction;
                    }
                }
            }
            if (VerticalScroll)
            {
                if (direction)
                {
                    GetComponent<ScrollRect>().verticalNormalizedPosition += ScrollSpeed * dt;
                    if (GetComponent<ScrollRect>().verticalNormalizedPosition > 1)
                    {
                        GetComponent<ScrollRect>().verticalNormalizedPosition = 1;
                        stop = true;
                        direction = !direction;
                    }
                }
                else
                {
                    GetComponent<ScrollRect>().verticalNormalizedPosition -= ScrollSpeed * dt;
                    if (GetComponent<ScrollRect>().verticalNormalizedPosition < 0)
                    {
                        GetComponent<ScrollRect>().verticalNormalizedPosition = 0;
                        stop = true;
                        direction = !direction;
                    }
                }
            }
            
        }
	}
}
