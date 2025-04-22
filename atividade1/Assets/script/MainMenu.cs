using UnityEngine;

namespace script
{
   public class MainMenu : MonoBehaviour
   {
      public void OnStartClicked()
      {
         GameManager.Instance.LoadScene("Game");
      }
      public void OnQuitClicked()
      {
         Application.Quit();
      }
   }
}
