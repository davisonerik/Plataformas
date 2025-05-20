using UnityEngine;

public class Door : MonoBehaviour
{
    [SerializeField] public string doorId; 


    private void OnEnable()
    {
        
        StaticEventChannel.OnButtonPressed += OnButtonPressed;
    }


    private void OnDisable()
    {
        
        StaticEventChannel.OnButtonPressed -= OnButtonPressed;
    }


    private void OnButtonPressed(string id)
    {
        Debug.Log("Recebi o evento para ID: " + id + " | Minha porta é: " + doorId);


       
        if (id == doorId)
        {
            OpenDoor();
        }
    }


    private void OpenDoor()
    {
      
        gameObject.SetActive(false);
    }

}
