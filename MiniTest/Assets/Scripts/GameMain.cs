using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameMain : MonoBehaviour
{
    public Button btnMoveStart;
    public Button btnMoveStop;
    public Image hpGauge;
    public Text coinText;
    public Cat cat;
    private int coinAmount;

    void Start()
    {
        this.UpdateCoinAmountText();

        cat.OnGetCoin = (amount) => {
            this.coinAmount += amount;
            this.UpdateCoinAmountText();
        };

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

    public void UpdateCoinAmountText() {
        this.coinText.text = this.coinAmount.ToString();
    }
}
