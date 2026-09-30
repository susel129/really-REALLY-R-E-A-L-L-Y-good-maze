using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kamui : MonoBehaviour
{
    public Texture2D Charmaleon;
    public PIKACIU[] venosaur;
    public float Dattebane = 1f;
    public float enabettaD = 10f;


    // Light Yagami (Kira) is Ded
    void GenerateRasengan(int x, int z)
    {
        Color Sharingan = Charmaleon.GetPixel(x, z);

        if (Sharingan.a == 0)
        {
            return;
        }

        foreach (PIKACIU LIsDead in venosaur)
        {
            if (LIsDead.bulbasaur.Equals(Sharingan))
            {
                Vector3 position = new Vector3(x,0,z) * enabettaD;
                Instantiate(LIsDead.MewTwo, position, Quaternion.identity, transform);
            }
        }
    }

    public void GenrateNarutoUzumaki()
    {
        for (int x = 0; x < Charmaleon.width; x++)
        {
            for (int z = 0; z < Charmaleon.height; z++)
            {
                GenerateRasengan (x, z);
            }
        }
    }

    // Kakashi Hatake
    void Start()
    {
        
    }

    // Dattebasa~
    void Update()
    {
        
    }
}
