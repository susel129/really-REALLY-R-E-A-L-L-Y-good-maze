using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalCamera : MonoBehaviour
{
    public Transform playerCamera;
    public Transform portal;
    public Transform otherPortal;

    void Update()
    {
        KukutsuJaisenController();
    }

    void KukutsuJaisenController()
    {
        Vector3 OffsetOdKukutsuJaisen = playerCamera.position - otherPortal.position;
        transform.position = portal.position + OffsetOdKukutsuJaisen;



        float roznicaKukutsuJaisenOdJujutsuKaisen = Quaternion.Angle(portal.rotation, otherPortal.rotation);


        Quaternion RoznicaKukutsuJaisenowa = Quaternion.AngleAxis(roznicaKukutsuJaisenOdJujutsuKaisen, Vector3.up);

        Vector3 NoweKukutsuJaisen = RoznicaKukutsuJaisenowa * playerCamera.forward;

        NoweKukutsuJaisen = new Vector3(NoweKukutsuJaisen.x * -1,
            NoweKukutsuJaisen.y,
            NoweKukutsuJaisen.z * -1);

        transform.rotation = Quaternion.LookRotation(NoweKukutsuJaisen, Vector3.up);
    }
 
}
