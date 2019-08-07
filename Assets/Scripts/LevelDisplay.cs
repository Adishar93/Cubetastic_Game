using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelDisplay : MonoBehaviour
{
   public Text level;
    // Start is called before the first frame update
    void Start()
    {
        
        level.text = "Level "+SceneManager.GetActiveScene().buildIndex.ToString();
    }

   
}
