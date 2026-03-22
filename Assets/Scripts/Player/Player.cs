using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Rigidbody2D myrigibody;
    public Vector2 velocity;
    private void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            myrigibody.MovePosition(myrigibody.position + velocity * Time.deltaTime);        }

        else if (Input.GetKey(KeyCode.RightArrow))
        {
            myrigibody.MovePosition(myrigibody.position - velocity * Time.deltaTime);
        }
    }
}
