using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other) {
        Debug.Log("touche");
        if (other.TryGetComponent(out Rigidbody rigidBody)) {
            rigidBody.velocity = Vector3.zero;
            rigidBody.useGravity = false;
            Collider collider = other.GetComponent<Collider>();
            Destroy(collider);
        }
    }
}
