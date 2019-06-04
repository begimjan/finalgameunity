using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class playercontroller : MonoBehaviour
{
    public Text hptext;
    int hp;
	Rigidbody rb;
    float x;
    float y;
    float z;
    public GameObject Bullet;
    GameObject cloneBullet;
    Rigidbody rbBullet;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        hp = 4;
    }

    // Update is called once per frame
    void Update()
    {
        float moveVertical = Input.GetAxis("Vertical");
        rb.AddForce(transform.forward * moveVertical *30f);


        float moveHorizontal = Input.GetAxis("Horizontal");
        rb.AddForce(transform.right * moveHorizontal *30f);    

         if(Input.GetKeyDown("space"))
        {
            cloneBullet = Instantiate(Bullet, new Vector3(transform.position.x,transform.position.y,transform.position.z + 1f), Quaternion.identity);
            rbBullet = cloneBullet.GetComponent<Rigidbody>();
            rbBullet.AddForce(transform.forward * 400f);


        }   
    }
        void OnCollisionEnter(Collision collision)
    {   
        if(collision.gameObject.tag =="enemy"){
            hp = hp - 1;
            hptext.text = "HP:" + hp;

        }
        if(hp <=0){
                SceneManager.LoadScene(1);
        }
      
      
    }
}
