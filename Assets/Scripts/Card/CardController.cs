using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardController : MonoBehaviour
{
    public Card cardDef;
    public GameObject cardObject;
    public Sprite cardImage;
    public float flipVelocity = 1;

    public bool flipCard;
    public bool hideCard;
    public bool showCard;

    void Start()
    {
        flipCard = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (flipCard) FlipCardUpdate();
        if (hideCard) HideCardUpdate();
        if (showCard) ShowCardUpdate();
    }

    public void UpdateCard()
    {
        cardImage = cardDef.Image;
    }

    public void FlipCard()
    {
        flipCard = true;
    }

    public void FlipCardUpdate()
    {
        float initalAngle = cardObject.transform.eulerAngles.y;
        Debug.Log(cardObject.transform.eulerAngles);
        cardObject.transform.Rotate(new Vector3(0, 1, 0) * flipVelocity );
        if(initalAngle < 180 && cardObject.transform.eulerAngles.y > 180)
        {
            flipCard = false;
            cardObject.transform.SetPositionAndRotation(cardObject.transform.position, Quaternion.Euler(0, 180, 0));
        }
        if (initalAngle > 180 && cardObject.transform.eulerAngles.y < 180)
        {
            flipCard = false;
            cardObject.transform.SetPositionAndRotation(cardObject.transform.position, Quaternion.Euler(0, 0, 0));
        }
    }

    public void ShowCard()
    {
        showCard = true;
    }

    public void ShowCardUpdate()
    {
        float initalAngle = cardObject.transform.eulerAngles.y;
        cardObject.transform.Rotate(new Vector3(0, 1, 0) * flipVelocity);
        if (initalAngle < 180 && cardObject.transform.eulerAngles.y > 180)
        {
            showCard = false;
            cardObject.transform.SetPositionAndRotation(cardObject.transform.position, Quaternion.Euler(0, 180, 0));
        }
    }

    public void HideCard()
    {
        hideCard = true;
    }

    public void HideCardUpdate()
    {
        float initalAngle = cardObject.transform.eulerAngles.y;
        cardObject.transform.Rotate(new Vector3(0, 1, 0) * flipVelocity);
        if (initalAngle > 180 && cardObject.transform.eulerAngles.y < 180)
        {
            hideCard = false;
            cardObject.transform.SetPositionAndRotation(cardObject.transform.position, Quaternion.Euler(0, 0, 0));
        }
    }

}
