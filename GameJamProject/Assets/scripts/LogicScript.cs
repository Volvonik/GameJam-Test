using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogicScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    bool IsDying(Vector2 position,Vector2 enemyPosition, int distance){
        //position is plant position and enemy position is the zombie position, distance is how many blocks away to mesure      
        if (position.x +48*distance == enemyPosition.x){
            return true;
            //the zombie is one block away from the plant
        }
        else{
            return false;
            //the zombie is one block away from the plant
        }
    }
}
