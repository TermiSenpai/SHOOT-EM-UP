using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PurchaseManager : MonoBehaviour
{
    [SerializeField] Shop shop;
    [SerializeField] GameObject BuyBtn;
    [SerializeField] GameObject equipBtn;

    [SerializeField] string boolData;
    [SerializeField] bool purchased = false;

    private void Start()
    {
        purchased = PlayerPrefs.GetInt(boolData) == 1;

        if (purchased)
            Purchased();
    }

    public void Purchased()
    {
        purchased = true;
        BuyBtn.SetActive(false);
        equipBtn.SetActive(true);
        PlayerPrefs.SetInt(boolData, purchased ? 1 : 0);
    }
}
