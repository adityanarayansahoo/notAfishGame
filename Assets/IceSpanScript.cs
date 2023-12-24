using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IceSpanScript : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject ice;
    public float spanRate = 4;
    public float timer = 0 ;
    float HightOffset=8 ;
    float count=0;
    
    public logicScript logic;
    void Start()
    {
          logic=GameObject.FindGameObjectWithTag("logic").GetComponent<logicScript>(); 
       spanice();  
    }

    // Update is called once per frame
    void Update()
    {
        if(timer < spanRate)
        {

            timer = timer + Time.deltaTime;
        }
        else
        {
            if(logic.playerScore >= 2 && logic.playerScore <= 4 && count< 4)
            {
                    count= count+ Time.deltaTime;
                    Debug.Log(count.ToString());
            }
            else
            {
            spanice();
            timer =0;
            Debug.Log("ice CREATED");

            }
        }
        
    }
    void spanice(){
        float lowestPoint= transform.position.y - HightOffset;
        float highestPoint = transform.position.y + HightOffset;

        Instantiate(ice, new Vector3(transform.position.x, Random.Range(lowestPoint,highestPoint), 0), transform.rotation);

    }
}
