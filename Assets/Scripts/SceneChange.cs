using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class SceneChange : MonoBehaviour
{

    // Button to know which scene to change to
    //public Text ButtonText;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //// If 3 finger touch
        //if (Input.touchCount == 3)
        //{
        //    //SceneManager.LoadScene("Scene2");
        //}
    }

    public void Change(string name)
    {
        var go = EventSystem.current.currentSelectedGameObject;

        SceneManager.LoadScene(name);
    }
}
