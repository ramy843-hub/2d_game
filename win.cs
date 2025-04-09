using UnityEngine;
using UnityEngine.SceneManagement ;
public class win : MonoBehaviour
{
    private AudioSource winAudio ;
    bool isComlete = false ;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
      winAudio = GetComponent<AudioSource>  ();
    }
    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.name == "player2" && !isComlete)
        {
            winAudio.Play();
            isComlete = true ;
            Invoke ("completeLevel",1f);
            
        }
    }
    void completeLevel ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
