using Unity.VisualScripting;
using UnityEngine;

public class PlatformCamera : MonoBehaviour
{
//   void OnCollisionEnter2D (Collision2D collision)
//   {
//         if (collision.gameObject.name == "player2")
//         {
//             collision.gameObject.transform.SetParent(transform);
//         }

//   }
//  void  OnCollisionExit2D (Collision2D collision)
//  {
//       if (collision.gameObject.name == "player2")
//         {
//             collision.gameObject.transform.SetParent(null);
//         }
//  }
  void OnTriggerEnter2D(Collider2D other)
{
    if (other.gameObject.name == "player2")
    {
        other.gameObject.transform.SetParent(transform);
    }
}

void OnTriggerExit2D(Collider2D other)
{
    if (other.gameObject.name == "player2")
    {
        other.gameObject.transform.SetParent(null);
    }
}
}
