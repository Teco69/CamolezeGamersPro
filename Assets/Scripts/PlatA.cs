using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatA : MonoBehaviour
{
    
    public Transform posA, posB;
    public int speed;
    Vector2 platPos;
    // Start is called before the first frame update
    void Start()
    {
        platPos=posB.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector2.Distance(transform.position, posA.position) < 0.1f)
        {
            platPos = posB.position;
        }
        if(Vector2.Distance(transform.position,posB.position) < 0.1f)
        {
            platPos=posA.position;
        }
        transform.position = Vector2.MoveTowards(transform.position, platPos, speed * Time.deltaTime);
        }
    void OnCollisionEnter2D(Collision2D colisao)
    {
        if (colisao.gameObject.CompareTag("Player")) { 
        colisao.transform.SetParent(this.transform);
        }

    }
    void OnCollisionExit2D(Collision2D colisao)
    {
        if (colisao.gameObject.CompareTag("Player"))
        {
            colisao.transform.SetParent(null);
        }
    }
}
