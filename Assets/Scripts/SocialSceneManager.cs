using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class SocialSceneManager : MonoBehaviour {

    public string highlighttab;
    public Image highlight;
    public Text DebugInfo;

	// Use this for initialization
	void Start () {
        highlighttab = "NIL";
        highlight.color = new Color(1f, 1f, 1f, 0.2f);
        ChangeHighlightTo("Guild Button");
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void ChangeHighlightTo(string tab)
    {
        highlighttab = tab;
        GameObject button = GameObject.Find(highlighttab);
        highlight.transform.position = button.transform.position;
        highlight.GetComponent<RectTransform>().sizeDelta = new Vector2(button.GetComponent<RectTransform>().rect.width, button.GetComponent<RectTransform>().rect.height);

        //DebugInfo.text = "Width: " + ButtonRectangle.rect.width + " Height: " + ButtonRectangle.rect.height;
    }
}
