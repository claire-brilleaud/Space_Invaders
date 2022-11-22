using System.Collections; 
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class Enemy : MonoBehaviour
{
    float timer = 0;
    float timeToMove = 0.5f; //it's the tempo of the movements 
    int numOfMovements = 0; //it define the border
    float speed = 0.1f;
    int limit = 43;

    public GameObject enemyProjectile;
    public GameObject enemyProjectileClone;
    public GameObject enemy;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if ((GameManager.playGame == true) && (GameManager.lives > 0))
        {
            //move sideways on timed interval
            timer += Time.deltaTime;
            if (timer > timeToMove && numOfMovements < limit)
            {
                transform.Translate(new Vector3(speed, 0, 0));
                timer = 0.2f; //to have a 'retro' effect
                numOfMovements++;
            }
            //move down after 43 movements direction
            if (numOfMovements == limit)
            {
                transform.Translate(new Vector3(0, -0.5f, 0));
                numOfMovements = -1;
                GameManager.touchPlayer++;
                speed = -speed;
                timer = 0.2f;
            }
            fireProjectileEnemy();
        }
    }
    void fireProjectileEnemy()
    {
        //System.Random r = new System.Random();
        if (Random.Range(0f,10000f) < 1)
        {
            enemyProjectileClone = Instantiate(enemyProjectile, new Vector3(enemy.transform.position.x, enemy.transform.position.y - 0.3f, 0), enemy.transform.rotation) as GameObject;
        }
    }
}
