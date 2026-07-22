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

    void CameraRotation()
    {
        float MYSZx = Input.GetAxis("Mouse X") * CzulaMyszka;
        float MYSZy = Input.GetAxis("Mouse Y") * CzulaMyszka;

        xRotation = -MYSZy;
        xRotation = Mathf.Clamp(xRotation, -130f, 130f);
        yRotation = MYSZx;
        yRotation = Mathf.Clamp(yRotation, -360f, 360f);

        transform.localRotation = Quaternion.Euler(xRotation, yRotation, 0f);
        Humanoid.Rotate(Vector3.up * MYSZx);
    }   


    // Useless Text
    void FixedUpdate()
    {
        CameraRotation();
    }
}
