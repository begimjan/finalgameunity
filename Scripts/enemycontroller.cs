using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class enemycontroller : MonoBehaviour
{
   public Transform player;
   public NavMeshAgent agent;
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        agent.SetDestination(player.transform.position);
    }
    void OnCollisionEnter(Collision other){
        if(other.gameObject.tag == "Bullet"){
        Destroy(gameObject);
        ScoreText.score++;
          if( ScoreText.score >= 4)
            {
                SceneManager.LoadScene(0);
            }



         

        }
        
    }


}
