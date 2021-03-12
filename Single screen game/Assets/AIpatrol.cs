using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class AIpatrol : MonoBehaviour
{
    [SerializeField] private UnityEvent<float> move;
    public Transform patrolLeft; patrolRight;
    private float moveDir = 1f;

 
    // Start is called before the first frame update
   

    // Update is called once per frame
    void Update()
    {
      if(transform.position.x < patrolLeft.position.x)
        {
        moveDir = 1;
        
}
 
       if(transform.position.x > patrolRight.position.x)
       {
        moveDir = -1;
        }
        move.Invoke(moveDir);

    }

    

 

