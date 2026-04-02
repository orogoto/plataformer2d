using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Rigidbody2D myrigibody;
    public Vector2 friction = new Vector2(.1f, 0);
    public float speed;
    public float jumpforce = 2;
    private void Update()
    {
        handlejump();
        handlemoviment();
    }

    private void handlemoviment()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            //myrigibody.MovePosition(myrigibody.position - velocity * Time.deltaTime);
            myrigibody.velocity = new Vector2(-speed, myrigibody.velocity.y);
        }

        else if (Input.GetKey(KeyCode.RightArrow))
        {
            //myrigibody.MovePosition(myrigibody.position + velocity * Time.deltaTime);
            myrigibody.velocity = new Vector2(speed, myrigibody.velocity.y);
        }

        if (myrigibody.velocity.x > 0)
        {
            myrigibody.velocity += friction;
        }

        else if (myrigibody.velocity.x < 0)
        {
            myrigibody.velocity -= friction;
        }

    }


    private void handlejump()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        { 
            myrigibody.velocity = Vector2.up * jumpforce;
        }
    }

}
