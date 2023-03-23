using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum enemyState 
{
    IDLE, ALERT, PATROL, FOLLOW, FURY
}



public class GameManager : MonoBehaviour
{
    public Transform player;

    [Header("Slime AI")]
    public Transform[] slimeWayPoints;
    public float slimeIdleWaitTime = 5f;
    public float slimeAlertTime = 3f;    
    public float slimedistanceToAttack = 2.3f;
    public float slimeAttackDelay = 1f;
    public float slimeLookAtSpeed = 1f; 
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
