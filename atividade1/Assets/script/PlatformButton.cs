
using script;
using UnityEngine;

public class PlatformButton : MonoBehaviour
{
    [SerializeField] private string doorIDOpen;


    private void OnTriggerEnter2D(Collider2D other)
    {
        
        
        if (other.CompareTag("Player"))
        {
            Debug.Log("Botão pressionado, enviando ID: " + doorIDOpen);


          StaticEventChannel.RaiseButtonPressed(doorIDOpen);
        }
    }

}
