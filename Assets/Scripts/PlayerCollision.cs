using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement movement;

    private void OnCollisionEnter(Collision collisionInfo)
    {
        
        if (collisionInfo.collider.tag == "Obstacle")
        {
            if (SetDestructionMode.destructive)
            {
                //movement.enabled = false;
                
                FindObjectOfType<TheGameManager>().EndGameDest();
            }
            else
            {
                movement.enabled = false;
                FindObjectOfType<TheGameManager>().EndGame();
            }
        }
    }

    
}
