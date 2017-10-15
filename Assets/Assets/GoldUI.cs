using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoldUI : MonoBehaviour
{
    public GameObject Player;
	
	// Update is called once per frame
	void Update ()
    {
        GetComponent<UnityEngine.UI.Text>().text
            = Player.GetComponent<Player>().Info.Gold.ToString();
	}
}
