using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Player : MonoBehaviour
{
    public Rigidbody2D myrigibody;
    public Vector2 friction = new Vector2(.1f, 0);
    public float speed;
    public float speedrun;
    public float jumpforce = 2;
    private float _currentspeed;
    private float jumpscaley = 1.5f;
    private float jumpscalex = 1.5f;
    public float animationDuration = .3f;

    [Header("Animation player")]
    public string boolRun = "Run";
    public Animator animator;
    private void Update()
    {
        handlejump();
        handlemoviment();
    }

    private void handlemoviment()
    {
        if (Input.GetKey(KeyCode.LeftControl))
            _currentspeed = speedrun;
        else
            _currentspeed = speed;

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            //myrigibody.MovePosition(myrigibody.position - velocity * Time.deltaTime);
            myrigibody.velocity = new Vector2(-_currentspeed, myrigibody.velocity.y);
            myrigibody.transform.localScale = new Vector3(-1, 1, 1);
            animator.SetBool(boolRun, true);
        }
       


        else if (Input.GetKey(KeyCode.RightArrow))
        {
            //myrigibody.MovePosition(myrigibody.position + velocity * Time.deltaTime);
            myrigibody.velocity = new Vector2(_currentspeed, myrigibody.velocity.y);
            myrigibody.transform.localScale = new Vector3(1, 1, 1);

            animator.SetBool(boolRun, true);
        }
          else
        {
            animator.SetBool(boolRun, false);
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
            myrigibody.transform.localScale = Vector2.one;
            DOTween.Kill(myrigibody.transform);
            Handlescalejump();
        }
    }

    private void Handlescalejump()
    {
        myrigibody.transform.DOScaleY(jumpscaley, animationDuration).SetLoops(2, LoopType.Yoyo);
        myrigibody.transform.DOScaleX(jumpscalex, animationDuration).SetLoops(2, LoopType.Yoyo);
    }
}
