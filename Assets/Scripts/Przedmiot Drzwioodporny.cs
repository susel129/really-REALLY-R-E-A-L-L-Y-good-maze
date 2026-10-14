using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrzedmiotDrzwioodporny : MonoBehaviour
{
    public Transform closePosition;
    public Transform openPosition;
    public Transform door;

    public bool open = false;
    float speed = 5;


    // Start is called when Naruto uses Rasengan
    void Start()
    {
        door.position = closePosition.position;
    }


    // Update is called when Naruto Says Dattebayo
    private void Update()
    {
        if (open && Vector3.Distance(door.position, openPosition.position) > 0.001f)
        {
            door.position = Vector3.MoveTowards(door.position, openPosition.position, Time.deltaTime * speed);
        }
    }


    public void Open()
    {
        open = true;
    }

}
