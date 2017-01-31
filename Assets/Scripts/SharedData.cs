using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;
using System.Collections;

public class SharedData : MonoBehaviour
{
    public static SharedData instance = null;
    public string CurrScene;
    public string PrevScene;

    public int EnergyLimit;
    public int Energy;

    public int PremiumCurrency;
    public int NormalCurrency;

    public List<GameObject> CheckInButtonList;

    protected SharedData(){}

    void CreateCheckIn()
    {
        int NumberOfDays = System.DateTime.DaysInMonth(System.DateTime.Now.Year, System.DateTime.Now.Month);
        int CurrentDay = System.DateTime.Now.Day;
        for (int i = 1; i <= NumberOfDays; i++)
        {
            GameObject temp = Instantiate(GameObject.Find("CheckInButton"));
            temp.name = "Check In " + i;
            temp.GetComponent<CheckInButton>().Index = i - 1;
            temp.GetComponentInChildren<Text>().text = "Day " + i;
            if (i > CurrentDay)
                temp.GetComponent<Button>().interactable = false;
            DontDestroyOnLoad(temp.transform.gameObject);
            CheckInButtonList.Add(temp);
        }
    }

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else 
        {
            Destroy(gameObject);
            return;
        }

        

        EnergyLimit = 9999;
        CreateCheckIn();
        DontDestroyOnLoad(transform.gameObject);
    }

    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
    }

    public SharedData GetInstance()
    {
        return instance;
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
