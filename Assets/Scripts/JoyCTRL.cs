using UnityEngine;
using UnityEngine.UI;
using System.Collections;


public class JoyCTRL : MonoBehaviour {

    public Text printOut;
    public Image ImgFG;
    public Image ImgBG;
    private bool positionSet;

	// Use this for initialization
	void Start () {
        ImgBG = GetComponent<Image>();
        ImgFG = transform.GetChild(0).GetComponent<Image>();
        ImgBG.transform.localScale = new Vector3(0, 0, 0);
        positionSet = false;
	}
	
	// Update is called once per frame
	void Update () {
        if (!positionSet && Input.GetMouseButtonDown(0))
        {
            OnClick();
            positionSet = true;
        }
        else if (positionSet && Input.GetMouseButtonUp(0))
        {
            ReturnOrigin();
            positionSet = false;
        }

        if (positionSet)
        {
            Dragging();
        }
	}

    public void OnClick()
    {
        Vector3 newPos = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 1);
        ImgBG.transform.position = newPos;
        ImgFG.transform.position = newPos;
        ImgBG.transform.localScale = new Vector3(1, 1, 1);
    }

    public void Dragging()
    {
        Vector3 MousePosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 1);
        Vector3 newPos = MousePosition - ImgBG.transform.position;
        if(newPos.magnitude < 60)
        ImgFG.rectTransform.position = MousePosition;
        else
        ImgFG.rectTransform.position = newPos.normalized * 60 + ImgBG.transform.position;
       
        printOut.text = "x: " + Input.mousePosition.x + "y: " + Input.mousePosition.y;
    }

    public void ReturnOrigin()
    {
        //GetComponent<MeshRenderer>().enabled = false;
        ImgFG.rectTransform.anchoredPosition = new Vector3(0, 0, 1);
        ImgBG.transform.localScale = new Vector3(0, 0, 1);
    }

    public void TestClick()
    {
        printOut.text = "Testing my click";
    }
}
