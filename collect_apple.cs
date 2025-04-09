using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class collect_apple : MonoBehaviour
{
    // public AudioSource collectAudio ;
    public TMP_Text cherriesText;
    private int numberCherries = 0;

    private void OnTriggerEnter2D(Collider2D collect)
    {
        if (collect.gameObject.CompareTag("cherries"))
        {
            // collectAudio.Play ();
            Destroy(collect.gameObject);
            numberCherries++;
            UpdateCherriesUI();
        }
    }

    private void UpdateCherriesUI()
    {
        cherriesText.text = "Apples: " + numberCherries;
    }
}
