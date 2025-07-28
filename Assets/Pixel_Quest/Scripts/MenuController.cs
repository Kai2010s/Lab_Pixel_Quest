using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    public string startScene;
    // Start is called before the first frame update
   public void LoadLevel()
    {
        SceneManager.LoadScene(startScene);
    }

    // Update is called once per frame
    public void QuitGame()
    {
        Application.Quit();
    }
}
