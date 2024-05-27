using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CarGameSenceManager : MonoBehaviour
{
    public void GameLoadSence(string level)
    {
        SceneManager.LoadScene(level);
    }
}
