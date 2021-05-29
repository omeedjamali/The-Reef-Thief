using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    public void loadLevel(string level) 
    {
        SceneManager.LoadScene(level);
    }

    public void quitlevel()
    {
        Application.Quit();
    }

    public void BrickDestroyed()
    {
            loadLevel("Win");
    }

}
