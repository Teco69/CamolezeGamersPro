using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Rigidbody2D rig;
    [SerializeField]
    private int speed;
    [SerializeField]
    private int jumpForce;
    bool chao = false;
    bool puloDuplo;
    // Start is called before the first frame update
    void Start()
    {
        rig= GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        mover();
        pulo();
    }

    void mover()
    {
        rig.velocity=new Vector2(Input.GetAxis("Horizontal")*speed,rig.velocity.y);
    }

    void pulo()
    {
        if (Input.GetButtonDown("Jump"))
        {
            if(chao)
            {
                rig.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
                chao = false; 
                puloDuplo = true;
            }else if(!chao && puloDuplo) {
                rig.AddForce(Vector2.up * jumpForce,ForceMode2D.Impulse);
                chao = false;
                puloDuplo = false;
            }
        }
    }
    private void OnCollisionEnter2D(Collision2D colisao)
    {
        if (colisao.gameObject.CompareTag("Plataforma"))
        {
            chao = true;
            puloDuplo= false;
        }
    }
}
