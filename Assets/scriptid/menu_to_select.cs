using UnityEngine;
using System.Collections;


public class menu_to_select : MonoBehaviour {
 
    public GameObject select;
    public GameObject menu;
    public GameObject juhend_lk;
    public GameObject info_lk;

    // Update is called once per frame
    void Update () {
     
         if(Input.GetKeyDown (KeyCode.Escape)){
             if(select.activeSelf == true){
 
                 select.SetActive(false);
                 menu.SetActive(true);
               
            }
            if (juhend_lk.activeSelf == true)
            {

                juhend_lk.SetActive(false);
                menu.SetActive(true);

            }
            if (info_lk.activeSelf == true)
            {

                info_lk.SetActive(false);
                menu.SetActive(true);

            }
            //      else {

            //        select.SetActive(true);
            //   menu.SetActive(false);
            

            //  }
            

        }
     
    }
    }
