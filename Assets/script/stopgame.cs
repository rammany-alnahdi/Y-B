using UnityEngine;
using UnityEngine.SceneManagement; 

public class stopgame : MonoBehaviour
{
    public Rigidbody ri;
    public Rigidbody ry;
    public GameObject controlinsidegame_winpaanal_activegameObject;
    public GameObject controlinsidegame_losepaanal_activegameObject;
    // Start is called before the first frame update
    void Start()
    {
         //time of game
        Time.timeScale = 1;

        

    }
    
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "death")
        {
            //panel
            controlinsidegame_losepaanal_activegameObject.SetActive(true);
            //froze players
            ri.constraints = RigidbodyConstraints.FreezeAll;
            ry.constraints = RigidbodyConstraints.FreezeAll;

        }
        if (collision.gameObject.tag == "Finish")
        {
            controlinsidegame_winpaanal_activegameObject.SetActive(true);
            // froze players
            ri.constraints = RigidbodyConstraints.FreezeAll;
            ry.constraints = RigidbodyConstraints.FreezeAll;
        }
        if (collision.gameObject.tag == "Finshall")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }

}
