using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class MainMenuSceneManager : MonoBehaviour {

    public Text EnergyText;
    public Text PremiumCurrencyText;
    public Text NormalCurrencyText;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        SharedData sharedData = GameObject.Find("SharedData").GetComponent<SharedData>();
        EnergyText.text = sharedData.Energy.ToString() + "/" + sharedData.EnergyLimit.ToString();
        NormalCurrencyText.text = sharedData.NormalCurrency.ToString();
        PremiumCurrencyText.text = sharedData.PremiumCurrency.ToString();
	}
}
