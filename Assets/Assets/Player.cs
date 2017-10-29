using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PlayerInfo
{
    public int Gold;
    public int GoldPerClick;
    public int GoldPerSec;
}

public class Player : MonoBehaviour
{
    public PlayerInfo Info;
    float Second;
    double aa;

	void Update ()
    {

        Second += Time.deltaTime;
        if (Second > 1.0f)
        {
            Info.Gold += Info.GoldPerSec;
            Second -= 1.0f;
        }
	}

    void OnMouseUpAsButton()
    {
        Info.Gold += Info.GoldPerClick;
        GetComponent<Rigidbody2D>().AddForce(new Vector2(0.0f, 1500.0f));
    }
}
