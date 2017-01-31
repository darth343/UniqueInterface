using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class MissionSelector : MonoBehaviour {

    public Text CurrMission;

    private int MissionNumber;
    private Vector2 startPos;
    private Vector2 direction;
    private Vector2 endPos;


	// Use this for initialization
	void Start () {
        MissionNumber = int.Parse(CurrMission.text);
	}
	
	// Update is called once per frame
	void Update () {
	
        if (Input.touchCount > 1)
        {
           Touch touch = Input.GetTouch(0);

			// Handle what to do based on touch phase
			switch (touch.phase) 
            {
				case TouchPhase.Began:
					startPos = touch.position;
					break;
				
				case TouchPhase.Ended:
                    // If dir is going left
                    if (endPos.x < startPos.x)
                    {
                        IncrementWorld(true);
                    }
                    // If dir is going right
                    else 
                    {
                        IncrementWorld(false);
                    }

					break;
			}
		}
	}

    public void IncrementWorld(bool isIncrement)
    {
        if (isIncrement)
        {
            MissionNumber++;

            if (MissionNumber > 10)
                MissionNumber = 1;
        }
        else
        {
            MissionNumber--;

            if (MissionNumber <= 0)
                MissionNumber = 10;
        }
        CurrMission.text = "World " + MissionNumber.ToString();
    }
}
