using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class SocialSceneManager : MonoBehaviour {

    public string highlighttab;
    public Image highlight;
    public Text DebugInfo;

    public GameObject GuildScene;
    public GameObject FriendScene;
    public GameObject MailScene;
    public GameObject SocialNetworkScene;

	// Use this for initialization
	void Start () {
        highlighttab = "NIL";
        highlight.color = new Color(1f, 1f, 1f, 0.2f);
        SwitchScene("Friends");
        DebugInfo.text = "NOTHING";
	}
	
	// Update is called once per frame
	void Update () {
	
	}


    public void SwitchScene(string name)
    {
        if (name == "Guild")
        {
            DebugInfo.text = name;
            GuildScene.SetActive(true);
            ChangeHighlightTo("Guild Button");
        }
        else
        {
            GuildScene.SetActive(false);
        }

        if (name == "Friends")
        {
            DebugInfo.text = name;
            FriendScene.SetActive(true);
            ChangeHighlightTo("Friends Button");
        }
        else
        {
            FriendScene.SetActive(false);
        }

        if (name == "Social Network")
        {
            DebugInfo.text = name;
            SocialNetworkScene.SetActive(true);
            ChangeHighlightTo("Social Network Button");
        }
        else
        {
            SocialNetworkScene.SetActive(false);
        }

        if (name == "Mail")
        {
            DebugInfo.text = name;
            MailScene.SetActive(true);
            ChangeHighlightTo("Mail Button");
        }
        else
        {
            MailScene.SetActive(false);
        }

    }

    public void ChangeHighlightTo(string tab)
    {
        highlighttab = tab;
        GameObject button = GameObject.Find(highlighttab);
        highlight.transform.position = button.transform.position;
        highlight.GetComponent<RectTransform>().sizeDelta = new Vector2(button.GetComponent<RectTransform>().rect.width, button.GetComponent<RectTransform>().rect.height);
    }
}
