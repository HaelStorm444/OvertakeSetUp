using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;

public class DrawCards : NetworkBehaviour
{
    public PlayerManager PlayerManager;
    /*
    public GameObject Card1;
    public GameObject Card2;
    public GameObject PlayerArea;
    */
    public void OnClick()
    {
        /*for(int i = 0; i < 6; i++)
        {
            GameObject card = Instantiate(Card1, new Vector2(0, 0), Quaternion.identity);
            card.transform.SetParent(PlayerArea.transform, false);
        }
        */

        NetworkIdentity networkIdentity = NetworkClient.connection.identity;
        PlayerManager = networkIdentity.GetComponent<PlayerManager>();
        PlayerManager.CmdDealCards();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
