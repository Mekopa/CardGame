using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dragger : MonoBehaviour
{
    private Vector3 _dragOffset;
    private Camera _cam;

    private void Awake()
    {
        _cam = Camera.main;
    }

    void OnMouseDown()
    {
        _dragOffset = transform.position - GetMausePos();
    }

    private void OnMouseDrag()
    {
        transform.position = GetMausePos() + _dragOffset;
    }

    Vector3 GetMausePos()
    {
        var mousePos = _cam.ScreenToWorldPoint(Input.mousePosition);
        return mousePos;
    }
}