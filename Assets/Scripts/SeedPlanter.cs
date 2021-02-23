using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeedPlanter : MonoBehaviour
{

    public GameObject planter;
    public GameObject seed;

    [Range(0, 10)]
    [Tooltip ("speed between 0-10")]
    public int planterSpeed;

    public float spawnTime;
    private float originalTime;

    [Range(1, 4)]
    [Tooltip ("1=Apple, 2=Orange, 3=Strawberry, 4=Watermelon")]
    public int lastChosenFruit;

    // Start is called before the first frame update
    void Start()
    {
        originalTime = spawnTime;
        lastChosenFruit = 1;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(0, Time.deltaTime * planterSpeed, 0));

        if(spawnTime<=0)
        {
            //plant seed
           GameObject newSeed = Instantiate(seed);
            newSeed.transform.position = planter.transform.position;
            newSeed.GetComponent<FruitGrower>().SetFruit(lastChosenFruit);

            //reset timer
            spawnTime = originalTime;
        }
        //increment timer
        spawnTime -= Time.deltaTime;


        //choese what fruit we want
        if (Input.GetKeyDown(KeyCode.A))
        {
            lastChosenFruit = 1;
        }
        else if (Input.GetKeyDown(KeyCode.O))
        {
            lastChosenFruit = 2;
        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            lastChosenFruit = 3;
        }
        else if (Input.GetKeyDown(KeyCode.W))
        {
            lastChosenFruit = 4;
        }

    }
}
