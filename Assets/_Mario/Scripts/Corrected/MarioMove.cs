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
        Vector3 mouvement = new Vector3(Input.GetAxis("Horizontal"), 0f, 0f);
        transform.position = transform.position + mouvement * Time.deltaTime;

        
        MarioAnimator.SetFloat("Speed", Mathf.Abs(mouvement.x));

        if (mouvement.x > 0.1)
        {
            MarioSpriteRenderer.flipX = true;
        }
        else if (mouvement.x < -0.1)
        {
            MarioSpriteRenderer.flipX = false;
        }
    }
}
