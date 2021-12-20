using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CPUMovement : MonoBehaviour
{

    public GameObject ball;
    private Rigidbody2D ballRigidBody;
    private Rigidbody2D cpuRigidBody;
    // Start is called before the first frame update
    void Start()
    {
        ballRigidBody = ball.GetComponent<Rigidbody2D>();
        cpuRigidBody = GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void Update()
    {

        if(ballRigidBody.position.y > cpuRigidBody.position.y){
            cpuRigidBody.position = new Vector2(cpuRigidBody.position.x, cpuRigidBody.position.y+0.05f);
        }
        if(ballRigidBody.position.y < cpuRigidBody.position.y){
            cpuRigidBody.position = new Vector2(cpuRigidBody.position.x, cpuRigidBody.position.y-0.05f);
        }        
    }
}
