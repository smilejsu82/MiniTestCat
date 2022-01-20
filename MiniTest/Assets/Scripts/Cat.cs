using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Cat : MonoBehaviour
{
    public float speed;
    private GameObject flagGo;
    private bool canMove = false;
    private Text distanceText;
    private float distance;
    void Start()
    {
        this.flagGo = GameObject.Find("flag");
        this.distanceText = GameObject.Find("distanceText").GetComponent<Text>();
        this.CalcDistance();
        this.UpdateDistanceText();
    }

    void Update()
    {
        if (this.canMove) {
            this.CalcDistance();
            this.UpdateDistanceText();

            if (distance > 0.2)
                this.transform.Translate(Vector2.right * this.speed * Time.deltaTime);
        }
    }

    private void CalcDistance() {
        this.distance = Vector2.Distance(this.transform.position, this.flagGo.transform.position);
    }

    private void UpdateDistanceText() {
        this.distanceText.text = distance.ToString() + "m";
    }

    public void MoveStart() {
        this.canMove = true;
    }

    public void MoveStop() {
        this.canMove = false;
    }
}
