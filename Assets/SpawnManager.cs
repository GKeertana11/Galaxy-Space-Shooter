using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject astroidPrefab;
    float time;
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        time =time+ Time.deltaTime;
        if (time >=3.0f)
        {
            transform.position = new Vector3(8.02f, Random.Range(-4.09f, 4.09f),  0);

            Instantiate(astroidPrefab, transform.position, Quaternion.identity);
           
            time = 0f;
        }
    }
}
