using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CardDisplay : MonoBehaviour
{
    public SpriteRenderer mySpriteRenderer;
    public Sprite front;
    public Sprite back;

    public void UpdateCardDisplay()
    {
        mySpriteRenderer.sprite = front;
    }
}
