using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;

public class IceMiddleScript : MonoBehaviour
{
    // Start is called before the first frame update
    public logicScript logic;
    void Start()
    {
        logic=GameObject.FindGameObjectWithTag("logic").GetComponent<logicScript>();
    }

    // Update is called once per frame
    void Update()
    {
       
    }
   private void OnTriggerEnter2D(Collider2D collision)
   {
    if(collision.gameObject.layer==3)
    {
    logic.addScore(1);
    }
       }
}
