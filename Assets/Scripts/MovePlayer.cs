using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{

    public Rigidbody2D body;

    // Start is called before the first frame update
    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {

        if(Input.GetKey(KeyCode.UpArrow)){
            body.position = new Vector2(body.position.x, body.position.y+0.05f);
        }
        if(Input.GetKey(KeyCode.DownArrow)){
            body.position = new Vector2(body.position.x, body.position.y-0.05f);
        }
        


        
    }
}
