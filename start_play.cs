using UnityEngine;
using UnityEngine.SceneManagement ;

public class start_play : MonoBehaviour
{
    public void start ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
    }
}
