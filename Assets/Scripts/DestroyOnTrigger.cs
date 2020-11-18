using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * This component destroys its object whenever it triggers a 2D collider with the given tag.
 */
public class DestroyOnTrigger : MonoBehaviour {
    [Tooltip("Every object tagged with this tag will trigger the destruction of this object and the other object")][SerializeField] string triggeringTag;

    private void OnTriggerEnter(Collider other) {
        if (other.tag == triggeringTag && enabled) {
            var PlayerMovement = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerMovement>();
            var controler = this.gameObject.GetComponent<FrogController>();
            // Destroy(other.gameObject);
            controler.Smashed();
            PlayerMovement.enabled = false;
        }
    }
}
