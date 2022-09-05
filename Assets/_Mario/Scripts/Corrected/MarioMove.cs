using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MarioMove : MonoBehaviour
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
        Vector3 motion = new Vector3(Input.GetAxis("Horizontal"), 0f, 0f);
        transform.position = transform.position + motion * Time.deltaTime;

        
        MarioAnimator.SetFloat("Speed", Mathf.Abs(motion.x));

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
