using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour {
    void OnTriggerEnter2D(Collider2D collision) {
        if (collision.gameObject.tag == "FoodAlgae") {
            Debug.Log("Hit algae.");
        }
    }
}
