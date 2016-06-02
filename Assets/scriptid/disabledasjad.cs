using UnityEngine;
using System.Collections;

public class disabledasjad : MonoBehaviour
{


    public GameObject select;
  
    public GameObject player2_wrap;
    public GameObject player3_wrap;
    public GameObject player4_wrap;
    public GameObject juhend_lk;
    public GameObject info_lk;
    public GameObject player1_gui;
    public GameObject player2_gui;
    public GameObject player3_gui;
    public GameObject player4_gui;
    public GameObject gameui;
    

    // Use this for initialization
    void Start()
    {
        select.SetActive(false);
        player2_wrap.SetActive(false);
        player3_wrap.SetActive(false);
        player4_wrap.SetActive(false);
        juhend_lk.SetActive(false);
        info_lk.SetActive(false);
        player1_gui.SetActive(false);
        player2_gui.SetActive(false);
        player3_gui.SetActive(false);
        player4_gui.SetActive(false);
        gameui.SetActive(false);
        

    }

    // Update is called once per frame
    void Update()
    {

    }
}