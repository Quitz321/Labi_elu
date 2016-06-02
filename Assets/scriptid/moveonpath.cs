using UnityEngine;
using System.Collections;


public class moveonpath : MonoBehaviour {

    public EditorPathScript PathToFollow;
    public dice tulemus;
    

    
    public int CurrentWayPointID ;
    public float speed = 10.0f;
    private float reachDistance = 65.0f;
    public float rotationSpeed = 1.0f;
    public string pathName;
    //see tuleb hiljem täringu pealt
    private int punktid;
    private int score;
    
    Vector3 current_position;
    private float distance;


    // Use this for initialization
    public void Start () {
        //PathToFollow = GameObject.Find(pathName).GetComponent<EditorPathScript>();



   punktid = punktid + score;
       

}


    // Update is called once per frame
   void Update () {
        score = tulemus.side;
        if (tulemus.transform.GetComponent<Rigidbody>().IsSleeping())
        {
            

        distance = Vector3.Distance(PathToFollow.path_objs [CurrentWayPointID].position, transform.position);
        transform.position = Vector3.MoveTowards(transform.position, PathToFollow.path_objs[CurrentWayPointID].position, Time.deltaTime * speed);

        var rotation = Quaternion.LookRotation(PathToFollow.path_objs [CurrentWayPointID].position - transform.position);
        transform.rotation = Quaternion.Slerp(transform.rotation, rotation, Time.deltaTime * rotationSpeed);

       /* if (CurrentWayPointID != punktid && distance <= reachDistance &&  punktid != 0)
        {
            CurrentWayPointID++;
            }*/

        }
             if (distance <= reachDistance){
                  CurrentWayPointID++;
             }
              if (CurrentWayPointID >= PathToFollow.path_objs.Count)
              {
                  CurrentWayPointID = 0;
              } 

        }
}

