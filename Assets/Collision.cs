using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour {
    public Stats stats;

    void OnTriggerEnter2D(Collider2D collision) {
        if (collision.gameObject.tag == "FoodAlgae") {
            stats.score += 10;
            Destroy(collision.gameObject);
        }
    }
}
