using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    public int moedas = 0;
    public float moveSpeed = 5f;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current.mKey.wasPressedThisFrame)
        {
            moedas++;
            PlayerObserverManager.ChangedMoedas(moedas);
            
        }
        float move = Input.GetAxis("Horizontal");
        transform.Translate(Vector2.right * (move * moveSpeed * Time.deltaTime));
    } 
   
        
    
}
