using UnityEngine;
using System.Collections;

public class SharedData : MonoBehaviour
{
    public static SharedData instance;
    public string CurrScene;
    public string PrevScene;

    protected SharedData(){}

    void Awake()
    {
        instance = this;
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
}
