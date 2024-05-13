using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TotalWeightUI : MonoBehaviour
{

    [SerializeField]
    private TextMeshProUGUI text;

    [SerializeField]
    private Player player;

    void Update()
    {
        setWeightValue();
    }

    private void setWeightValue()
    {
        text.text = "" + player.getInventory().getTotalWeight();
    }


}
