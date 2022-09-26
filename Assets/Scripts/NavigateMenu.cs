using UnityEngine;
using UnityEngine.SceneManagement;

public class NavigateMenu : MonoBehaviour
{
   
    public void ReloadLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
