using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public BirdController BirdScript;
    public GameObject Borular;
    public float heigth;
    public float time;
   
    void Start()
    {
       StartCoroutine(SpawnObject(time));
    }

  
    void Update()
    {
        
    }
    public IEnumerator SpawnObject(float time)
    {
        while(!BirdScript.isDeath)
        {
        
        Instantiate(Borular, new Vector3(3,Random.Range(-heigth , heigth),0),Quaternion.identity);
        yield return new WaitForSeconds(time);
        }
       
    }


}
