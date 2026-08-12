using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GugulToFirma : MonoBehaviour
{
    // Lost in Paradise When Night's And Day's are Fading Out (Guess Anime Reference)
    Transform Humanoid;
    [SerializeField]
    private float xRotation = 0f;
    [SerializeField]
    private float yRotation = 0f;
    [SerializeField]
    private float CzulaMyszka = 500f;

    // Useless Text
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Humanoid = transform.parent;
    }

    private void CameraRotation()
    {
        float mouseX =
            Input.GetAxis("Mouse X") * CzulaMyszka * Time.deltaTime;

        float mouseY =
            Input.GetAxis("Mouse Y") * CzulaMyszka * Time.deltaTime;


        xRotation -= mouseY;


        xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);

        Humanoid.Rotate(Vector3.up * mouseX);
    }


    // Useless Text
    void FixedUpdate()
    {
        CameraRotation();
    }
}
