using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoneyManager : MonoBehaviour
{

    public float money;
    public UIMANAGER uiManager;

    // Start is called before the first frame update
    void Start()
    {
        uiManager.UpdateMoneyTxt(money.ToString());
    }

    
    public void UpdateMoneyTxt(float moneyToAdd)
    {
        if (money + moneyToAdd < 0)
        {
            Debug.Log("No Te Alcanza");
            return;
        }
        money += moneyToAdd;
        uiManager.UpdateMoneyTxt(money.ToString());
    }

}
