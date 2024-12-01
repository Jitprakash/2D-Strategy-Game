using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trap : MonoBehaviour
{
    public int trapLife;
    public GameObject blood;
    private Animator caAnim;//! To fetch a animation from camara
    // Start is called before the first frame update
    void Start()
    {
        caAnim= Camera.main.GetComponent<Animator>();//! Fething..
    }

    // Update is called once per frame
    void Update()
    {
        
    }
  private void OnTriggerEnter2D(Collider2D other) {
    if (other.tag == "Enemy") {
      caAnim.SetTrigger("shake");//! To trigger the animation

      trapLife--;
      Destroy(other.gameObject);
      Instantiate(blood,transform.position,Quaternion.identity);
      EnemySpawner.enemyInstance.enemyCount--;
      if (trapLife <= 0) {
        Destroy(gameObject);
      }
    }
  }
}