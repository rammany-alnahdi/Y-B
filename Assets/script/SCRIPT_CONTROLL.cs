using UnityEngine;
using UnityEngine.SceneManagement;

public class SCRIPT_CONTROLL : MonoBehaviour
{
   public void quitgame()
    {
        Application.Quit(); 
    }
    public void nextgame()
    {
        
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1);  
    }
    public void retry_game()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex );
    }
    public void main_go()
    {
        SceneManager.LoadScene(0); 
    }
}
