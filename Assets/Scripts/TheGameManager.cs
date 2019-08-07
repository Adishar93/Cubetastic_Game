using UnityEngine;
using UnityEngine.SceneManagement;

public class TheGameManager : MonoBehaviour
{
    bool gameHasEnded = false;
    public float restartDelay = 1.5f;
    public float levelChangeDelay = 2.5f;
    public GameObject completeLevelUI;
    public GameObject player;
    public static bool itHappened = true;
    

   public void EndGame()
    {
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            Debug.Log("Game Over");
            Invoke("Restart", restartDelay);
            
        }
    }

    public void EndGameDest()
    {
        if (itHappened)
        {
            itHappened = false;
            Invoke("ResetPosition", restartDelay);
            
        }
            
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void ResetPosition()
    {
        player.transform.position = new Vector3(0.36f,1,0);
        itHappened = true;
    }

    public void CompleteLevel()
    {
        completeLevelUI.SetActive(true);
        //Invoke("Restart", levelChangeDelay);
    }
}
