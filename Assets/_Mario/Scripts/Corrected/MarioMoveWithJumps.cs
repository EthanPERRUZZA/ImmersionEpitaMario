using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MarioMoveWithJumps : MonoBehaviour
{
    //Variable qui nous permettra de faire le lien entre l'animator et notre code sur Mario
    public Animator MarioAnimator;

    //Variable qui nous permettra de faire le lien entre le Sprite Renderer et notre code sur Mario
    public SpriteRenderer MarioSpriteRenderer;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Saut
        if (Input.GetKey(KeyCode.Space) && GetComponent<Rigidbody2D>().velocity.y == 0)
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(0f, 3f);
        }

        //Animation Saut
        if (GetComponent<Rigidbody2D>().velocity.y != 0)
        {
            MarioAnimator.SetBool("IsJumping", true);
        }
        else
        {
            MarioAnimator.SetBool("IsJumping", false);
        }

        //Avancer
        Vector3 motion = new Vector3(Input.GetAxis("Horizontal"), 0f, 0f);
        transform.position = transform.position + motion * Time.deltaTime;

        //Animation Avancer
        MarioAnimator.SetFloat("Speed", Mathf.Abs(motion.x));

        //Changement du cote ou regade mario en fct de direction
        if (motion.x > 0.1)
        {
            MarioSpriteRenderer.flipX = true;
        }
        else if (motion.x < -0.1)
        {
            MarioSpriteRenderer.flipX = false;
        }
    }
}
