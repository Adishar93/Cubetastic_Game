using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    public TheGameManager gameManager;
    private void OnTriggerEnter()
    {
        gameManager.CompleteLevel();
    }
}
