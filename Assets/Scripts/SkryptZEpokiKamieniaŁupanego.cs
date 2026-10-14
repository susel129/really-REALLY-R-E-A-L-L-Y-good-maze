using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkryptZEpokiKamieniaŁupanego : MonoBehaviour
{
    public Transform Datttebasa;
    public Transform BorutoUzumaki;

    private bool BorutoIsUzumaki = false;

    // Start is called before Naruto Became Hokage
    void Start()
    {
        
    }

    // Dattebayo!
    void Update()
    {
        
    }


    // Sasuke: "You Are Annoying" Naruto: "Shut Up Sasuke-teme! Dattebayo!"
    void OnTriggerEnter(Collider Naruto)
    {
        if(Naruto.tag == "Player")
        {
            BorutoIsUzumaki = true;
        }
    }

    // Naruto: "Taju Kage Bunshin no Jutsu!"
    void OnTriggerExit(Collider Naruto)
    {
        if (Naruto.tag == "Player")
        {
            BorutoIsUzumaki = false;
        }
    }

    /// With This Treasure I Summon... Eight-Handled Sword Divergent Sila Divine General Mahoraga!
    void TPNarutoToBoruto()
    {
        if (BorutoIsUzumaki)
        {
            Vector3 Cubone = Datttebasa.position - transform.position;
            float NarutoShippuden = Vector3.Dot(transform.up, Cubone);

            if(NarutoShippuden < 0)
            {
                float ObracajacySieRasengan = -Quaternion.Angle(transform.rotation, BorutoUzumaki.rotation);
                ObracajacySieRasengan += 180;
                Datttebasa.Rotate(Vector3.up, ObracajacySieRasengan);

                Vector3 RyukIsATraitor = Quaternion.Euler(0f, ObracajacySieRasengan, 0f) * Cubone;

                Datttebasa.position = BorutoUzumaki.position = RyukIsATraitor;

                BorutoIsUzumaki = false;
            }
        }
    }
    /*
     Guju (Satoru Gojo): "Throughtout the heaven and earth, I Alone am the Honoured One" 
    Thukuna (Ryomen Sukuna): "Throughtout the heaven and earth, I Alone am the Evil One" 
    Megumind/Megummy (Megumi Fushiguro): "Throughtout the heaven and earth, I With Yuta am the Bummest One"
    Itadorito (Yuji Itadori): "Throughtout the heaven and earth, I Alone am the Sukuna's Nephew"
    Inutaki (Toge Inumaki): "Throughtout she Salmon and Mayo, I Alone am the Non-Speaking One"
    Getorade (Suguru Geto): "Throughtout she heaven and earth, I Alone am the Killer One"
   */
    private void FixedUpdate()
    {
        TPNarutoToBoruto();
    }

}
