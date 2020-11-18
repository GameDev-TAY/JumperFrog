using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinTheGame : MonoBehaviour
{
    [Tooltip("Every object tagged with this tag will trigger the destruction of this object and the other object")] [SerializeField] string triggeringTag;

    private void OnTriggerEnter(Collider other)
    {
       
        if (other.tag == triggeringTag && enabled)
        {
            //var PlayerMovement = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerMovement>();
            other.gameObject.GetComponent<MeshRenderer>().enabled = true;
           // PlayerMovement.enabled = false;
        }
    }
}
