using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeedPlanter : MonoBehaviour
{

    public GameObject planter;
    public GameObject seed;

    public float timer;
    private float originalTime;

    // Start is called before the first frame update
    void Start()
    {
        originalTime = timer;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(0, Time.deltaTime * 10, 0));

        if(timer<=0)
        {
            //plant seed
           GameObject newSeed = Instantiate(seed);
            newSeed.transform.position = planter.transform.position;
            //reset timer
            timer = originalTime;
        }
        //increment timer
        timer -= Time.deltaTime;
    }
}
