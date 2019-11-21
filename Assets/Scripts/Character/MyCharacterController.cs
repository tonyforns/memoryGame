using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MyCharacterController : MonoBehaviour
{
    public Character characterDef;
    public Text Life;
    public Text Mana;
    public Text Name;
    public Text Description;
    public Sprite Image;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void UpdateCharacter()
    {
        Life.text = characterDef.Life.ToString();
        Mana.text = characterDef.Mana.ToString();
        Name.text = characterDef.Name;
        Description.text = characterDef.Description;
        Image = characterDef.Image;
    }

}
