using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitGrower : MonoBehaviour
{

    public float growtime;
    public float expireTime;
    public GameObject apple;
    public GameObject orange;
    public GameObject strawberry;
    public GameObject watermelon;


    public GameObject fruit;
    public GameObject seed;




    // Start is called before the first frame update
     public void SetFruit(int x) 
     {
        switch (x)
        {
            case 1:
                fruit = apple;
                break;
            case 2:
                fruit = orange;
                break;
            case 3:
                fruit = strawberry;
                break;
            case 4:
                fruit = watermelon;
                break;
            default:
                Debug.LogWarning("You must chose an integer 1-4");
                    break;
        }

            
        

        
     }

    // Update is called once per frame
    void Update()
    {
        if (growtime <= 0)
        {
            seed.SetActive(false);
            fruit.SetActive(true);
        }

        if (expireTime <= 0)
        {
            Destroy(gameObject);
        }

        growtime -= Time.deltaTime;
        expireTime -= Time.deltaTime;
    }


}
