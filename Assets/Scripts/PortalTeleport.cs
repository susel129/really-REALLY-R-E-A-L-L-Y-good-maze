using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEngine;

public class PortalTeleport : MonoBehaviour
{

    public Transform player;
    public Transform receiver;
    
    private bool playerIsOverlapping = false;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            playerIsOverlapping = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            playerIsOverlapping = false;
        }
    }


    void Apapejszyn()
    {
        if (playerIsOverlapping)
        {
            Vector3 PTP = player.position - transform.position;
            float doProduct = Vector3.Dot(transform.up, PTP);
            if (doProduct < 0f)
            {
                float rotationDiff = Quaternion.Angle(transform.rotation, receiver.rotation);
                rotationDiff += 180;
                player.Rotate(Vector3.up, rotationDiff);

                Vector3 positionOffset = Quaternion.Euler(0f, rotationDiff, 0f) * PTP;
                player.position = receiver.position;
            }
        }

        void FixedUpdate()
        {
            Apapejszyn();
        }
    }
    
}


