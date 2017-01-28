using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;
using System.Collections;

public class SharedData : MonoBehaviour
{
    public static SharedData instance;
    public string CurrScene;
    public string PrevScene;

    private int EnergyLimit;
    public int Energy;
    public Text EnergyText;

    public int PremiumCurrency;
    public Text PremiumCurrencyText;

    public int NormalCurrency;
    public Text NormalCurrencyText;

    protected SharedData(){}

    void Awake()
    {
        instance = this;
        EnergyLimit = 9999;
        Energy = 1000;
        EnergyText.text = Energy.ToString() + "/" + EnergyLimit.ToString();

        PremiumCurrency = 1000;
        PremiumCurrencyText.text = PremiumCurrency.ToString();

        NormalCurrency = 1000;
        NormalCurrencyText.text = NormalCurrency.ToString();

        DontDestroyOnLoad(transform.gameObject);
    }

    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        EnergyText.text = Energy.ToString() + "/" + EnergyLimit.ToString();
        PremiumCurrencyText.text = PremiumCurrency.ToString();
        NormalCurrencyText.text = NormalCurrency.ToString();
    }

    public void IncreaseNormalCurrency(int amount)
    {
        NormalCurrency += amount;
    }

    public void DecreaseNormalCurrency(int amount)
    {
        NormalCurrency -= amount;
    }
}
