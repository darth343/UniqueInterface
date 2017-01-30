using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GuildQuestsInstantiater : MonoBehaviour {

	// Use this for initialization
	void Start () {
        CreateQuest("Kills", "Kill 200 Enemies", 150f, 200f);
        CreateQuest("Kills", "Kill 1000 Enemies", 150f, 1000f);
        CreateQuest("Kills", "Kill 800 Enemies", 150f, 800f);
        CreateQuest("Kills", "Kill 900 Enemies", 150f, 900f);
        CreateQuest("Kills", "Kill 2 Enemies", 1f, 2f);
        CreateQuest("Kills", "Kill 200 Enemies", 150f, 200f);
        CreateQuest("Kills", "Kill 1000 Enemies", 150f, 1000f);
        CreateQuest("Kills", "Kill 800 Enemies", 150f, 800f);
        CreateQuest("Kills", "Kill 900 Enemies", 150f, 900f);
        CreateQuest("Kills", "Kill 2 Enemies", 1f, 2f);
        CreateQuest("Kills", "Kill 200 Enemies", 150f, 200f);
        CreateQuest("Kills", "Kill 1000 Enemies", 150f, 1000f);
        CreateQuest("Kills", "Kill 800 Enemies", 150f, 800f);
        CreateQuest("Kills", "Kill 900 Enemies", 150f, 900f);
        CreateQuest("Kills", "Kill 2 Enemies", 1f, 2f);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void CreateQuest(string Name, string Description, float progress, float progressMax)
    {
        GameObject temp = Instantiate(GameObject.Find("Guild Quest Template"));
        temp.name = Name;

        // Set Description
        temp.transform.Find("Description").GetComponent<Text>().text = Description;
        // Set Gauge text
        temp.transform.Find("TextGauge").GetComponent<Text>().text = progress.ToString() + "/" + progressMax.ToString();
        // Set Image Fill
        temp.transform.Find("ImageGauge").GetComponent<Image>().fillAmount = progress / progressMax;

        temp.transform.SetParent(this.transform);
    }
}
