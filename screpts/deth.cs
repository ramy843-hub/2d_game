using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement ;
public class deth : MonoBehaviour
{
    private Rigidbody2D rb ;
    private Animator An ;
    public AudioSource deathAudio ;

   
    void Start()
    { 
        rb = GetComponent<Rigidbody2D>();
        An = GetComponent<Animator>();
        
        
    }
    


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("traps"))
        {
            deathAudio.Play() ;
            Die();
        }
    }
    private void Die()
    {
        rb.bodyType = RigidbodyType2D.Static ;
        An.SetTrigger("death");
        
    }
    private void RestartLevel() 
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
   
        
 
}
