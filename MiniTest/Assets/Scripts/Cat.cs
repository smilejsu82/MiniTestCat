using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cat : MonoBehaviour
{
    public float speed;
    private GameObject flagGo;
    private bool canMove = false;

    void Start()
    {
        this.flagGo = GameObject.Find("flag");    
    }

    void Update()
    {
        if (this.canMove) {
            float distance = Vector2.Distance(this.transform.position, this.flagGo.transform.position);

            if (distance > 0.2)
                this.transform.Translate(Vector2.right * this.speed * Time.deltaTime);
        }
    }

    public void MoveStart() {
        this.canMove = true;
    }

    public void MoveStop() {
        this.canMove = false;
    }
}
