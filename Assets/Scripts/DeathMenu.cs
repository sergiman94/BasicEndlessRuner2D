using UnityEngine;
using System.Collections;
using System.Runtime.CompilerServices;

public class DeathMenu : MonoBehaviour
{

    public string mainMenuLevel;

    public void RestartGame()
    {

        FindObjectOfType<GameManager>().Reset();

    }

    public void QuitToMainMenu()
    {

        Application.LoadLevel(mainMenuLevel);
    }
}
