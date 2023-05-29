using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControls : MonoBehaviour {
    public float movementSpeed = 0.0f;
    public float baseMovementSpeed = 2.0f; 
    public float maxMovementSpeed = 10.0f;

    // basically __init__()
    void Start() {
        // reset the players position to the centre on startup
        transform.position = new Vector2(0, 0);
    }

    // Update is called once per frame
    void Update() {
        Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        float dist = Vector2.Distance(mousePosition, transform.position);

        // if left mouse button held down
        if (Input.GetMouseButton(0)) {
            movementSpeed = baseMovementSpeed * dist;
            if (movementSpeed > maxMovementSpeed) {
                movementSpeed = maxMovementSpeed;
            }
            transform.position = Vector2.MoveTowards(transform.position, mousePosition, movementSpeed * Time.deltaTime);
        }
    }
}
