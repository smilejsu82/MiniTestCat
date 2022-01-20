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
            //UI를 갱신 한다 
            //cat의 hp와 maxHp를 알아야 한다 
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
