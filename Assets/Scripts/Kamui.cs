using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Kamui : MonoBehaviour
{
    public Texture2D Charmaleon;
    public PIKACIU[] Venosaur;
    public float Dattebane = 1f;
    public float enabettaD = 10f;


    // Light Yagami (Kira) is Ded
    void GenerateRasengan(int x, int z)
    {
        Color32 Sharingan = Charmaleon.GetPixel(x, z);

            if (Sharingan.a == 0)
            {
                return;
            }

            foreach (PIKACIU LIsDead in Venosaur)
            {
                Color32 mappingColor = LIsDead.bulbasaur;

                if (Sharingan.r == mappingColor.r &&
                    Sharingan.g == mappingColor.g &&
                    Sharingan.b == mappingColor.b)
                {
                    Vector3 MaximumOutputBLUE =
                        transform.position +
                        new Vector3(x * Dattebane, 0, z * Dattebane);

                    Instantiate(
                        LIsDead.MewTwo,
                        MaximumOutputBLUE,
                        Quaternion.identity,
                        transform
                    );

                    break;
                }
            }
        }

    //Uzumaki Naruto Desu
    public void GenrateNarutoUzumaki()
    {
        for (int x = 0; x < Charmaleon.width; x++)
        {
            for (int z = 0; z < Charmaleon.height; z++)
            {
                GenerateRasengan(x, z);
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