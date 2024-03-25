using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class FiringArrow : MonoBehaviour
{
    public GameObject arrow;
    

    protected bool charging = false;
    protected bool firing = false;
    protected float power = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) {
            charging = true;
        }
        if (Input.GetKeyUp(KeyCode.Space)) {
            charging = false;
            firing = true;
        }
        if (charging) {
            power += 2;
        }
        if (firing) {
            GameObject newObject = Instantiate(arrow, transform.position, transform.rotation, null);
            newObject.transform.Rotate(newObject.transform.right, 90);

            if (newObject.TryGetComponent(out Rigidbody rigidBody)) {
                Vector3 force = transform.forward * power;
                rigidBody.AddForce(force);
                Debug.Log(power);
            }
            firing = false;
            power = 100;
        }
        
    }
}
