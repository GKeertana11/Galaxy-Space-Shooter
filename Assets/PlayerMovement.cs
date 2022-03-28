using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    public float speed;
    BulletLauncher Bullet;
    // Start is called before the first frame update
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
    float inputX = Input.GetAxis("Horizontal");
    float inputY= Input.GetAxis("Vertical");
        transform.Translate(Vector3.up * speed * inputY * Time.deltaTime);
        transform.Translate(Vector3.right * speed * inputX* Time.deltaTime);

        if(transform.position.y>4.2f)
        {
            transform.position = new Vector3(transform.position.x, 4.2f, 0);

        }
       else if (transform.position.y <-4.2f)
        {
            transform.position = new Vector3(transform.position.x, -4.2f, 0);

        }

        if (transform.position.x > 8.0f)
        {
            transform.position = new Vector3(8.0f,transform.position.y,  0);

        }
        else if (transform.position.x < -8.0f)
        {
            transform.position = new Vector3(-8.0f, transform.position.y, 0);

        }

    }

   /* private void OnTriggerEnter2D(Collider2D collision)
    {

        if (gameObject.tag == "Astroid")
        {
            Destroy(gameObject);
            //ScoreManager.Score(10);
            // source.Play();
        }
    }
   */
}
