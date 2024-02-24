using UnityEngine;

public class playermovement : MonoBehaviour
{
    public Rigidbody rb1;
    public Transform tr;
    public Rigidbody RBOTHER;
    

    //object move
    public float speedplayer ;
    //object hight
    public float bodyhight;
    public LayerMask maskgraound;

    //jump
    public bool check2 = true;
    public bool check =true;
    public float jumpcool;
    public float jumpforce;



    //key code
    public KeyCode jumpkey2;
    

    // Update is called once per frame
    void FixedUpdate()
    {
        check = Physics.Raycast(transform.position, Vector3.down, bodyhight * 0.5f + 0.2f, maskgraound);
        
        input();
    }
    
    //input
    private void input()
    {
        //forword move
        if (rb1.velocity.z < 8f )
            rb1.AddForce(0, 0, speedplayer * Time.deltaTime);
        //fixblack
        if(rb1.position.z - RBOTHER.position.z > 0.05)
            RBOTHER.AddForce(0, 0, 0.02f*speedplayer * Time.deltaTime);

        // jump

        if ((Input.GetKey(jumpkey2)) && check2 && check)
        {

            jump();
            
            Invoke(nameof(rest), jumpcool);
        }
       
    }
    //jump function
    private void jump()
    {
        check = false;
        check2 = false;
        //reset vilasty.y 0 

        rb1.velocity = new Vector3(0f, 0f, rb1.velocity.z * 0.9f);
        RBOTHER.velocity = new Vector3(0f, RBOTHER.velocity.y, RBOTHER.velocity.z * 0.9f);
        rb1.AddForce(new Vector3(0f,1,0f) *jumpforce, ForceMode.Impulse);
        
    }
    void rest()
    {
        check2 = true;
    }

}
