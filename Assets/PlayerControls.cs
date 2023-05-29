using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControls : MonoBehaviour {
    [SerializeField]
    private float movementSpeed = 0.0f;
    float baseMovementSpeed = 2.0f; 
    float maxMovementSpeed = 6.5f;

    // Update is called once per frame
    void Update() {
        //rotation
        // get mouse position
        Vector3 mousePos = Input.mousePosition;
        // because we are in 2d the z axis does not matter and we can set to 0
        mousePos.z = 0;

        // get the position of the mouse within the world
        Vector3 objectPos = Camera.main.WorldToScreenPoint(transform.position);
        // find the difference between the x and y of the player and the mouse on x and y axis
        mousePos.x = mousePos.x - objectPos.x;
        mousePos.y = mousePos.y - objectPos.y;

        float angle = Mathf.Atan2(mousePos.y, mousePos.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(new Vector3(0, 0, angle));

        // movement
        Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        float dist = Vector2.Distance(mousePosition, transform.position);

        if (Input.GetMouseButton(0)) {
            movementSpeed = baseMovementSpeed * dist;
            if (movementSpeed > maxMovementSpeed) {
                movementSpeed = maxMovementSpeed;
            }
            transform.position = Vector2.MoveTowards(transform.position, mousePosition, movementSpeed * Time.deltaTime);
        }
    }
}
