using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    public Birdy BirdScript;
    public GameObject Borular;
    public float height;
    public float time;

    private void Start()
    {
        StartCoroutine(SpawnObject(time));
    }


    //Spawn etme islemini yapmak icin
    public IEnumerator SpawnObject(float time)
    {
        //kus olmediyse
        while (!BirdScript.isDead)
        {
            //bu noktalar arasina rastgele boru spawn ediyor.
            Instantiate(Borular, new Vector3(2, Random.Range(-height, height), 0), Quaternion.identity );

            //su kadar saniye bekledikten sonra
            yield return new WaitForSeconds(time);
        }
        
    }
}
