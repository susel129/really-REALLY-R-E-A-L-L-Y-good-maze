using System.Collections;
using System.Collections.Generic;
using Unity.Burst.CompilerServices;
using UnityEngine;

public class APAP : MonoBehaviour
{

    public LayerMask MaskaAnyAPAPOWAuselessowa; 
    public Transform Duolingo;
    public RaycastHit Heat;

    [SerializeField] float speed = 12f;
    Vector3 Fefofity;
    CharacterController CCC;

    private void OnControllerColliderHit(ControllerColliderHit other)
    {
        if (other.gameObject.tag == "Podnoszacz")
        {
            other.gameObject.GetComponent<OgólneŻarełko>().Zapapiono();
        }
    }





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

        if (Physics.Raycast(Duolingo.position, //If you didn't you're spain lesson, Ððñ† †µrñ ßå¢k (Duoling.position == behind you)

      transform.TransformDirection(Vector3.down),
        out Heat, 0.4f, MaskaAnyAPAPOWAuselessowa))
        {

        }
    }

    // Useless Text
    void Update()
    {
        APAPplays();
    }
}
