using UnityEngine;

public class movePlatform : MonoBehaviour
{
    public GameObject[] ponits ;
    int currentPoint = 0 ;
    public float spped = 2f ;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector2.Distance(ponits[currentPoint].transform.position,transform.position) < .1f )
         {
            currentPoint ++ ;
            if (currentPoint >= ponits.Length)
            {
                currentPoint = 0 ;
            }
         }
        transform.position = Vector2.MoveTowards (transform.position ,ponits[currentPoint].transform.position,Time.deltaTime*spped );
    }
}
