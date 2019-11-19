using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardController : MonoBehaviour
{
    public Card cardDef;
    public GameObject cardObject;
    public Sprite cardImage;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdateCard()
    {
        cardImage = cardDef.Image;
    }

    public void FlipCard()
    {

    }

}
