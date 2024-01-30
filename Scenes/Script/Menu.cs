using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void RestartGameScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

    }
}
