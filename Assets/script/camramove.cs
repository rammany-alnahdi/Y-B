using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camramove : MonoBehaviour
{
    public Transform tplayer;
    public Vector3 movecam ;

    Vector3 v;




    // Update is called once per frame
    void FixedUpdate()
    {
        v = tplayer.position;
        v.y = 0; 
        transform.position = v + movecam;

    }
}
