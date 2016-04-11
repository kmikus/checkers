﻿using UnityEngine;
using System.Collections;

public class MoveCheckers : MonoBehaviour {

    float distance = 5;

    void OnMousedrag()
    {
        Vector3 mousePosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, distance);
        Vector3 objPosition = Camera.main.ScreenToWorldPoint(mousePosition);

        transform.position = objPosition;
    }
}
