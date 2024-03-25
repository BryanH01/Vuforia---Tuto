using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class AstronautAnimation : MonoBehaviour
{
    private Animator m_Animator;
    private bool drill = false;
    private bool wave = false;
    private bool idle = true;

    void Start() {
        m_Animator = gameObject.GetComponent<Animator>();
    }

    void Update() {
        if (Input.GetKeyDown(KeyCode.D)) {
            Debug.Log("Launching Drilling Animation");
            wave = false;
            idle = false;
            drill = true;
            m_Animator.SetBool("IsWaving", wave);
            m_Animator.SetBool("IsDrilling", drill);
        }

        if (Input.GetKeyDown(KeyCode.W)) {
            Debug.Log("Launching Waving Animation");
            wave = true;
            drill = false;
            idle = false;
            m_Animator.SetBool("IsWaving", wave);
            m_Animator.SetBool("IsDrilling", drill);
        }

        if (Input.GetKeyDown(KeyCode.Space)) {
            Debug.Log("Launching Idling Animation");
            wave = false;
            drill = false;
            idle = true;
            m_Animator.SetBool("IsWaving", wave);
            m_Animator.SetBool("IsDrilling", drill);
        }
    }
}
