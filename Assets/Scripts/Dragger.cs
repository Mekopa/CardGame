using UnityEngine;
using UnityEngine.EventSystems;

public class Dragger : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    private RectTransform rectTransform;
    private CanvasGroup canvasGroup;
    private Vector2 originalPosition;

    [SerializeField] private Canvas canvas;

    private void Awake()
    {
        rectTransform = GetComponent<RectTransform>();
        canvasGroup = GetComponent<CanvasGroup>();
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        originalPosition = rectTransform.anchoredPosition;
        canvasGroup.alpha = 0.6f;
        canvasGroup.blocksRaycasts = false;
    }

    public void OnDrag(PointerEventData eventData)
    {
        rectTransform.anchoredPosition += eventData.delta / canvas.scaleFactor;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        canvasGroup.alpha = 1f;
        canvasGroup.blocksRaycasts = true;

        // Check if the card is over the play area
        if (RectTransformUtility.RectangleContainsScreenPoint(
            PlayArea.Instance.playAreaRectTransform,
            Input.mousePosition,
            Camera.main))
        {
            PlayArea.Instance.AddCardToPlayArea(GetComponent<Card>());
        }
        else
        {
            // Return to original position if not dropped in play area
            rectTransform.anchoredPosition = originalPosition;
        }
    }
}


