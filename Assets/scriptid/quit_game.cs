using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class quit_game : MonoBehaviour {
    public GameObject quit_it;
    // Use this for initialization
    void Start()
    {
        quit_it.SetActive(false);
    }
        // Update is called once per frame
        void Update () {
        if (quit_it.activeSelf == true)
        {
            Application.Quit();

        }
       
    }

}
