using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class lobbyScript : MonoBehaviour
{
    public void joinGame ()
    {
        Debug.Log("Joining Game");
        SceneManager.LoadScene("game");
    }

    public void createGame ()
    {
        Debug.Log("Creating Game");
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
    }

    public void goBackToMainMenuFromLobby()
    {
        Debug.Log("Going Back to Main Menu");
        SceneManager.LoadScene("Menu");
    }
}
