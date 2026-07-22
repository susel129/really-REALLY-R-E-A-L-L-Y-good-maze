using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class APAP : MonoBehaviour
{
    [SerializeField] float speed = 12f;
    Vector3 Fefofity;
    CharacterController CCC;
    // Useless Text
    void Start()
    {
        CCC = GetComponent<CharacterController>();
    }

    void APAPplays()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 movement = transform.right * x + transform.forward * z;
        CCC.Move(movement * speed * Time.deltaTime);
    }

    // Useless Text
    void Update()
    {
        APAPplays();
    }
}
