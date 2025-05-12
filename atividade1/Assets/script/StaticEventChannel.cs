using System;
using UnityEngine;

public class StaticEventChannel
{
    public static event Action<string> OnButtonPressed;


    // Método que dispara (notifica) todos os ouvintes desse evento
    public static void RaiseButtonPressed(string doorId)
    {
        // Verifica se existe alguém inscrito no evento antes de chamar
        OnButtonPressed?.Invoke(doorId);
    }

}
