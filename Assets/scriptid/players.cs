using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class players : MonoBehaviour {

    public GameObject startgame_blank;
    public Dropdown players_ripp;
    public InputField player1;
    public InputField player2;
    public InputField player3;
    public InputField player4;
    public GameObject player1_wrap;
    public GameObject player2_wrap;
    public GameObject player3_wrap;
    public GameObject player4_wrap;
    public GameObject player1_gui;
    public GameObject player2_gui;
    public GameObject player3_gui;
    public GameObject player4_gui;
    public GameObject select;
    public GameObject gameui;
    private int player_count;
    public string player1_name;
    public string player2_name;
    public string player3_name;
    public string player4_name;




    // Use this for initialization
    void Start () {
        
        


    }


// Update is called once per frame
void Update () {
        player_count = players_ripp.value+1;
        player1_name = player1.text;
        player2_name = player2.text;
        player3_name = player3.text;
        player4_name = player4.text;

        if (players_ripp.value == 0)
        {
            player1_wrap.SetActive(true);
            player2_wrap.SetActive(false);
            player3_wrap.SetActive(false);
            player4_wrap.SetActive(false); 
    }
    if (players_ripp.value == 1)
    {
            player1_wrap.SetActive(true);
            player2_wrap.SetActive(true);
            player3_wrap.SetActive(false);
            player4_wrap.SetActive(false);
        }
    if (players_ripp.value == 2)
    {
            player1_wrap.SetActive(true);
            player2_wrap.SetActive(true);
            player3_wrap.SetActive(true);
            player4_wrap.SetActive(false);
        }
    if (players_ripp.value == 3)
    {
        player1_wrap.SetActive(true);
        player2_wrap.SetActive(true);
        player3_wrap.SetActive(true);
        player4_wrap.SetActive(true);
    }
        //game start
        if (startgame_blank.activeSelf == false) { 
            select.SetActive(false);
            gameui.SetActive(true);
      
            

            
            
            player2_name = player2.text;
            player3_name = player3.text;
            player4_name = player4.text;
            if (player_count == 1){ 
                player1_gui.SetActive(true);
        }
        if (player_count == 2){
                player1_gui.SetActive(true);
                player2_gui.SetActive(true);
        }
            if (player_count == 3){
                player1_gui.SetActive(true);
                player2_gui.SetActive(true);
                player3_gui.SetActive(true);
            }
            if (player_count == 4){
                player1_gui.SetActive(true);
                player2_gui.SetActive(true);
                player3_gui.SetActive(true);
                player4_gui.SetActive(true);
             }
        }
    }
}
