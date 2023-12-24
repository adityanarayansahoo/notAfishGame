using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveIce : MonoBehaviour
{
    public float moveSpeed =6;
    public float deadZone= -40;
    public float speedIncriment=0;

    public float playerScoreTracker=0;
    public logicScript logic;
    // Start is called before the first frame update
    void Start()
    {
       logic=GameObject.FindGameObjectWithTag("logic").GetComponent<logicScript>(); 
    }

    // Update is called once per frame
    void Update()
    {   

        if(logic.playerScore >= 4){        //if(speedIncriment!= logic.playerScore)
            if (logic.playerScore > playerScoreTracker) {
                speedIncriment=logic.playerScore;
                moveSpeed= moveSpeed + speedIncriment/2;
                playerScoreTracker = logic.playerScore;
            }
        }
        else
        {   
            if(logic.playerScore<3 )
         {
            moveSpeed =6;
         }
        }
        transform.position = transform.position + (Vector3.left *  moveSpeed) * Time.deltaTime;

        Debug.Log("speed " + moveSpeed.ToString () +" score" + logic.playerScore);
        
        
        

        // moveSpeed+=moveSpeed+1;
        // moveSpeed=moveSpeed*Time.deltaTime;

        if(transform.position.x <= deadZone){
            Debug.Log("ice deleted");
            Destroy(gameObject);
        }
    }
}
