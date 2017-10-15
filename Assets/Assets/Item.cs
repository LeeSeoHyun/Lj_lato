using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    public GameObject Player;
    public int GoldPerClick;
    public int GoldPerSec;
    public int Cost;

    public void Buy()
    {
        PlayerInfo Info = Player.GetComponent<Player>().Info;

        if (Info.Gold > Cost)
        {
            Info.Gold -= Cost;
            Info.GoldPerClick += GoldPerClick;
            Info.GoldPerSec += GoldPerSec;
        }
    }
}
