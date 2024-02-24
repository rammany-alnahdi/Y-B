using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class smart_fance : MonoBehaviour
{
    bool chekplayer=false;
    public GameObject show1;
    public GameObject show2;
    
    public GameObject hide;
    public Transform fancepos;
    public Transform playerfar;
    
    


    // Update is called once per frame
    void Update()
    {

        if (fancepos.position.z - playerfar.position.z < 23f)
            chekplayer = true;
        if(chekplayer)
        {
            show1.SetActive(true);
            show2.SetActive(true);
            hide.SetActive(false);
            chekplayer = false;
            
        }
    }
}
