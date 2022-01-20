using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameMain : MonoBehaviour
{
    public Button btnMoveStart;
    public Button btnMoveStop;

    public Cat cat;

    void Start()
    {
        this.btnMoveStart.onClick.AddListener(()=> {
            cat.MoveStart();
        });
        this.btnMoveStop.onClick.AddListener(() => {
            cat.MoveStop();
        });
    }
}
