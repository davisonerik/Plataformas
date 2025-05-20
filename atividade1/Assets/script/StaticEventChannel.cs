using System;
    public class StaticEventChannel
    {
        public static event Action<string> OnButtonPressed;


       
        public static void RaiseButtonPressed(string doorId)
        {
          
            OnButtonPressed?.Invoke(doorId);
        }

    }

