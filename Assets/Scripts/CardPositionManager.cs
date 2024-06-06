using UnityEngine;

public class CardPositionMannager : MonoBehaviour
{
    public GameObject player1;
    public GameObject player2;
    public GameObject closeCard1;
    public GameObject closeCard2;
    public GameObject openCard1;
    public GameObject openCard2;

    // Define the positions where you want the objects to be placed
    private Vector3 player1Position = new Vector3((float)-4.5, 5, 0);
    private Vector3 player2Position = new Vector3((float)-4.5, -5, 0);
    private Vector3 closeCard1Position = new Vector3(-2, (float)1.2, 0);
    private Vector3 closeCard2Position = new Vector3(-2, (float)-1.2, 0);
    private Vector3 openCard1Position = new Vector3(-2, (float)1.2, 0);
    private Vector3 openCard2Position = new Vector3(-2, (float)-1.2, 0);

    void Start()
    {
        Debug.Log("Starting CardPositionMannager");

        // Set the positions of the parent objects
        SetGlobalPosition(player1, player1Position, "Player 1");
        SetGlobalPosition(player2, player2Position, "Player 2");
        SetGlobalPosition(closeCard1, closeCard1Position, "Close Card 1");
        SetGlobalPosition(closeCard2, closeCard2Position, "Close Card 2");
        SetGlobalPosition(openCard1, openCard1Position, "Open Card 1");
        SetGlobalPosition(openCard2, openCard2Position, "Open Card 2");

        // Position the individual cards within each parent
        PositionCardsLocally(player1, 1.5f, "Player 1");
        PositionCardsLocally(player2, 1.5f, "Player 2");
        PositionCardsLocally(closeCard1, 1.5f, "Close Card 1");
        PositionCardsLocally(closeCard2, 1.5f, "Close Card 2");
        PositionCardsLocally(openCard1, 1.5f, "Open Card 1");
        PositionCardsLocally(openCard2, 1.5f, "Open Card 2");
    }

    void SetGlobalPosition(GameObject obj, Vector3 position, string name)
    {
        if (obj != null)
        {
            obj.transform.position = position;
            Debug.Log($"{name} positioned at {position} globally");
        }
        else
        {
            Debug.LogError($"{name} is not assigned!");
        }
    }

    void PositionCardsLocally(GameObject parent, float spacing, string parentName)
    {
        if (parent != null)
        {
            for (int i = 0; i < parent.transform.childCount; i++)
            {
                Transform child = parent.transform.GetChild(i);
                Vector3 newPosition = new Vector3(i * spacing, 0, 0);
                child.localPosition = newPosition; // Set local position relative to the parent
                Debug.Log($"Positioned {child.name} at local position {newPosition} relative to {parentName}");
            }
        }
        else
        {
            Debug.LogError($"Parent GameObject {parentName} is null!");
        }
    }

    void OnDrawGizmos()
    {
        // Draw gizmos for debugging purposes
        Gizmos.color = Color.red;
        DrawGizmoForObject(player1, player1Position);

        Gizmos.color = Color.blue;
        DrawGizmoForObject(player2, player2Position);

        Gizmos.color = Color.green;
        DrawGizmoForObject(closeCard1, closeCard1Position);

        Gizmos.color = Color.yellow;
        DrawGizmoForObject(closeCard2, closeCard2Position);

        Gizmos.color = Color.magenta;
        DrawGizmoForObject(openCard1, openCard1Position);

        Gizmos.color = Color.white;
        DrawGizmoForObject(openCard2, openCard2Position);
    }

    void DrawGizmoForObject(GameObject obj, Vector3 position)
    {
        if (obj != null)
        {
            Gizmos.DrawWireSphere(position, 0.5f);
        }
    }
}








