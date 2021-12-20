using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallMovement : MonoBehaviour
{

    public Rigidbody2D body;
    private Vector2 lastVel;
    // Start is called before the first frame update
    public Text text;

    

    int counter;
    void Start()
    {
        body.velocity = new Vector2(Random.Range(5.0f, 10.0f), Random.Range(5.0f, 10.0f));
        counter = 0;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        lastVel = body.velocity;



    }

    void OnCollisionEnter2D(Collision2D other)
    {
        body.velocity = Vector2.Reflect(lastVel, other.contacts[0].normal);

        if(other.gameObject.name =="Player"){
            other.gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(0,0);
            counter++;
            text.text = "Score: " + counter.ToString();
        }

        if(other.gameObject.name =="CPU"){
            other.gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(0,0);
        }

        if(other.gameObject.name == "Left"){
            Destroy(this.gameObject);
            text.text = "YOU LOSE!";
        }

        if(other.gameObject.name == "Right"){
            Destroy(this.gameObject);
            text.text = "YOU WIN!";
        }
    }
}
