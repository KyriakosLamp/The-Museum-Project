using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class showCash : MonoBehaviour 
{

    public Text cashtext;
    
    public CashSystem CashSystemRef;
    // Update is called once per frame
    void Update()
    {
        cashtext.text = "Cash: " + CashSystemRef.getCash()+"$";
    }
}
