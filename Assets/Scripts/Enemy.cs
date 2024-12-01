using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
//! Enemy behaviors
public class Enemy : MonoBehaviour
{
    public float speed;
    public float minX,maxX,minY,maxY;
    Vector3 currentTarget;
    public static Enemy enemy;
    // Start is called before the first frame update
    void Start()
    {
        enemy=this;
        currentTarget=getRandomPosition();//! Setting a random position where the enemy will move towards
    }

    // Update is called once per frame
    void Update()
    {
        //! Enemy movement
        if (Vector3.Distance(transform.position,currentTarget)>0.5f)
        {
            transform.position= Vector3.MoveTowards(transform.position, currentTarget,speed *Time.deltaTime);
            //? this MoveTowards method take 3 arguments: current position, target position & spped.
            
        }else
        {
            currentTarget = getRandomPosition();//! If the enemy is close enough to the current target, set a new random position.
        }
        
    }
    Vector3 getRandomPosition()
    {
        // float x = Random.Range(minX, maxX);
        // float y = Random.Range(minY, maxY);
        // return new Vector3(x, y, 0); //? Also works but we can minimize the code

        Vector3 randomPosition = new Vector3(Random.Range(minX, maxX), Random.Range(minY, maxY),0);
        return randomPosition;
    }
    private void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == "Alter")//! If the enemy collides with Alter Restart the game.
        {
            SceneManager.LoadScene(3);
        }
    }
}
