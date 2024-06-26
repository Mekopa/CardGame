using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dragger : MonoBehaviour
{
    private Vector3 _dragOffset;
    private Camera _cam;
    public bool isDragging = false;
    private CanvasGroup canvasGroup;
    private RectTransform rectTransform;
    public LayerMask playAreaLayerMask;
    public LayerMask faceUpAreaLayerMask;
    public MyFaceUpCards upCards1;
    public MyFaceUpCards upCards2;
    public MyFaceDownCards downCards1;
    public MyFaceDownCards downCards2;
    public MyPlayer player1;
    public MyPlayer player2;

    private void Awake()
    {
        _cam = Camera.main;
        rectTransform = GetComponent<RectTransform>();
        canvasGroup = GetComponent<CanvasGroup>();
    }

    public void OnMouseDown()
    {
        _dragOffset = transform.position - GetMausePos();
        isDragging = true;

    }

    public void OnMouseDrag()
    {
        transform.position = GetMausePos() + _dragOffset;
    }
    public void OnMouseUp()
    {
        isDragging = false;
       CheckFaceUpArea();
        CheckPlayArea();

        // Check if the card is over the play area
       
    }
    Vector3 GetMausePos()
    {
        var mousePos = _cam.ScreenToWorldPoint(Input.mousePosition);
        mousePos.z = 0;
        Debug.Log("Converted Mouse Position: " + mousePos);
        return mousePos;
    }



    void CheckFaceUpArea()
    {
        RaycastHit2D hit = Physics2D.Raycast(GetMausePos(), Vector2.zero, Mathf.Infinity, faceUpAreaLayerMask);

        if (hit.collider != null)
        {
            Debug.Log("Raycast hit something: " + hit.collider.gameObject.name);
            MyFaceUpCards faceUpArea = hit.collider.GetComponent<MyFaceUpCards>();
            Card card = GetComponent<Card>();
            if (card.GetComponentInParent<MyPlayer>(true) == player1 || card.GetComponentInParent<MyPlayer>(true) == player2)
            {
                card.GetComponentInParent<MyPlayer>(true).RemoveCard(card);
            }
            Debug.Log("Play are name: " + faceUpArea);
            Debug.Log("Card name: " + card);
            if (faceUpArea != null && card != null)
            {
                Debug.Log("Raycast hit player area");
                faceUpArea.TakeCard(card);
            }
            else
            {
                Debug.Log("Raycast did not hit a player area or card is null");
            }
        }
        else
        {
            Debug.Log("Raycast did not hit anything");
        }

    }
    void CheckPlayArea()
    {
        RaycastHit2D hit = Physics2D.Raycast(GetMausePos(), Vector2.zero, Mathf.Infinity, playAreaLayerMask);

        if (hit.collider != null)
        {
            Debug.Log("Raycast hit something: " + hit.collider.gameObject.name);
            PlayArea playArea = hit.collider.GetComponent<PlayArea>();
            Card card = GetComponent<Card>();
            Debug.Log("Play are name: " + playArea);
            Debug.Log("Card name: " + card);
            if (card.GetComponentInParent<MyPlayer>(true) != null  )
            {
                card.GetComponentInParent<MyPlayer>(true).RemoveCard(card);
            }
            else if(card.GetComponentInParent<MyFaceUpCards>(true) != null)
            {
                card.GetComponentInParent<MyFaceUpCards>(true).RemoveCard(card);
            }
            else if (card.GetComponentInParent<MyFaceDownCards>(true) != null)
            {
                card.GetComponentInParent<MyFaceDownCards>(true).RemoveCard(card);
            }
            if (playArea != null && card != null)
            {
                Debug.Log("Raycast hit player area");
                playArea.AddCard(card);
            }
            else
            {
                Debug.Log("Raycast did not hit a player area or card is null");
            }
            if(card.name == "Card 13")
            {
                
                playArea.RemoveAll(card);
            }
        }
        else
        {
            Debug.Log("Raycast did not hit anything");
        }

    }
}