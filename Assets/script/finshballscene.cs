using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class finshballscene : MonoBehaviour
{
    public Rigidbody finshball;
    public float ballhight;
    bool ground;
    public LayerMask maskgraound;
    private void Update()
    {
        ground = Physics.Raycast(transform.position, Vector3.down, ballhight * 0.5f + 0.2f,maskgraound);
        jump();
    }
    public void jump()
    {
        if (ground)
        {
            //reset vilasty.y 0 
            finshball.velocity = new Vector3(0f, 0f, 0f);
            finshball.AddForce(transform.up * 2f, ForceMode.Impulse);
            ground = false;
        }
    }
}
