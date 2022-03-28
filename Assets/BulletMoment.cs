using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMoment : MonoBehaviour
{
    public float bulletspeed;
    //AudioSource source;
    ScoreManager ScoreManager;
    Rigidbody2D rb;
    BulletLauncher bulletLauncher;
    // Start is called before the first frame update
    void Start()
    {
        //source = GetComponent<AudioSource>();
        rb = GetComponent<Rigidbody2D>();
        ScoreManager = GameObject.Find("ScoreManager").GetComponent<ScoreManager>();
        bulletLauncher = GameObject.Find("Player").GetComponent<BulletLauncher>(); }
    
    

    // Update is called once per frame
    void Update()
    {
        //transform.Translate(0, bulletspeed, 0);
        rb.velocity = new Vector2(transform.position.x, bulletspeed*transform.position.y);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {

        if(collision.gameObject.tag=="Astroid")
        {
            Destroy(collision.gameObject);
            ScoreManager.Score(10);
            bulletLauncher.BackToBulletPool(this.gameObject);
           // source.Play();
        }
    }
}
