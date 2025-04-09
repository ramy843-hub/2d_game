using UnityEngine;

public class rotation : MonoBehaviour
{
    public float rotationSpeed = 100f; 
   
   

    void Update()
    {
        transform.Rotate(0, 0 ,360*rotationSpeed * Time.deltaTime);

       
    }
}
