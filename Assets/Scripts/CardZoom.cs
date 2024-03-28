using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Mirror;

public class CardZoom : NetworkBehaviour
{
    private GameObject zoomCard;
    private Sprite zoomSprite;

    public GameObject Canvas;
    public GameObject ZoomCard;

    public void Awake()
    {
        Canvas = GameObject.Find("Main Canvas");
        zoomSprite = gameObject.GetComponent<Image>().sprite;
    }

    public void OnHoverEnter()
    {
        //determine whether the client hasAuthority over this gameobject
        if (!isOwned) return;

        //if the client hasAuthority, create a new version of the card with the appropriate sprite
        zoomCard = Instantiate(ZoomCard, new Vector2(Input.mousePosition.x, Input.mousePosition.y + 250), Quaternion.identity);
        zoomCard.GetComponent<Image>().sprite = zoomSprite;

        //make the card a child of the Canvas so that it is rendered on top of everything else
        zoomCard.transform.SetParent(Canvas.transform, true);

        //make the card bigger!
        RectTransform rect = zoomCard.GetComponent<RectTransform>();
        rect.sizeDelta = new Vector2(240, 344);
    }

    public void OnHoverExit()
    {
        Destroy(zoomCard);
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
