using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameMain : MonoBehaviour
{
    public Button btnMoveStart;
    public Button btnMoveStop;
    public Image hpGauge;

    public Cat cat;

    void Start()
    {
        cat.OnHit = () =>
        {
            //UI�� ���� �Ѵ� 
            //cat�� hp�� maxHp�� �˾ƾ� �Ѵ� 
            var per = this.cat.GetHp() / this.cat.GetMaxHp();
            this.hpGauge.fillAmount = per;  //0 ~ 1
        };

        this.btnMoveStart.onClick.AddListener(()=> {
            cat.MoveStart();
        });
        this.btnMoveStop.onClick.AddListener(() => {
            cat.MoveStop();
        });
    }
}
