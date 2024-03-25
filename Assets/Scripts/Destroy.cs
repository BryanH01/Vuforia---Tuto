using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour {

    protected float initTime;
    public float lifeTime = 10;

    // Start is called before the first frame update
    void Start() {
        initTime = Time.time;
    }

    // Update is called once per frame
    void Update() {
        if (lifeTime < Time.time - initTime) {
            Destroy(gameObject);
        }
    }
}
