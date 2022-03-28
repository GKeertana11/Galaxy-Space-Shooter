using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletLauncher : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject bulletPrefab;
    public GameObject[]  bullets;
    Stack<GameObject> Bulletstack = new Stack<GameObject>();
    private static BulletLauncher instance;
    public static BulletLauncher Instance
    {
        get
        {
            if(instance==null)
            {
                instance = GameObject.FindObjectOfType<BulletLauncher>();
            }
            return instance;

        }
    }


    // AudioSource source;
    //  public AudioClip audioClip;


    public Vector3 offset;
    void Start()
    {
        CreateBullet();
        //source = GetComponent<AudioSource>();
    }

    private void SpawnBullet(int value)
    {
        if(Bulletstack.Count==0)
        {
            CreateBullet();
        }
       
            GameObject tempBullet = Bulletstack.Pop();
            tempBullet.SetActive(true);
            tempBullet.transform.position = transform.position + offset;
        


    }

    private void CreateBullet()
    {
        for (int i=0;i<20;i++)
        {
            Bulletstack.Push(Instantiate(bulletPrefab));
            bulletPrefab.SetActive(false);
                
        }
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetButtonDown("Fire1"))

        {
            //  Instantiate(bulletPrefab, transform.position + offset, Quaternion.identity);
            SpawnBullet(10);
           // source.Play();
        }

    }
    public void BackToBulletPool(GameObject obj)
    {
        obj.SetActive(false);
        Bulletstack.Push(obj);
    }
}
