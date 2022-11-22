using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static int lives = 3;
    public static bool playGame = true;
    public static int nbEnemy = 36;
    public static int touchPlayer = 0;

    public Text livesText;
    public Text endScreen;
    // Start is called before the first frame update
    void Start()
    {
        livesText.text = "Lives: " + lives;
    }

    // Update is called once per frame
    void Update()
    {
        livesText.text = "Lives: " + lives;
        if(lives == 0 && GameManager.touchPlayer > 10)
        {
            endScreen.text = "YOU LOSE, LOSER";
        }
        else if (nbEnemy == 0)
        {
            endScreen.text = "YOU WIN !";
        }
    }
}
