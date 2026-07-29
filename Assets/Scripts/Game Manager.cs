using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public static GameManager Instance;
    [SerializeField] int ZeitZunSchloss;
    bool iDunnoMaybeeeeeAPAP = false;
    bool iToldYaToEatAPAPnOWyOUREdEAD = false;
    bool BRAVOyOUaTEaPAP = false;




    // Usless Text like Useless Miwa
    void Start()
    {
        if (Instance == null)
        {
            Instance = this;
        }

        if (ZeitZunSchloss <= 0)
        {
            ZeitZunSchloss = 100;
        }
    }

    void Stepper()
    {
        ZeitZunSchloss--;
        if (ZeitZunSchloss <= 0)
        {
            ZeitZunSchloss = 0;
            iToldYaToEatAPAPnOWyOUREdEAD = true;
        }

        if (iToldYaToEatAPAPnOWyOUREdEAD)
        {

        }
    }

    void IchBitteDichStoppeDieseSpielNicht()
    {
        Debug.Log("WHY THE HELL HAVE YOU PAUSED THIS STUPID GAME");
        Time.timeScale = 0f;
        iDunnoMaybeeeeeAPAP = true;
    }
    void DankeDirFurSpielen()
    {
        Debug.Log("thx ;P");
        Time.timeScale = 1f;
        iDunnoMaybeeeeeAPAP = false;
    }

    void ScwipinwIwHawd()
    {
        if (BRAVOyOUaTEaPAP)
        {
            Debug.Log("HELL, YOU WON");
        }
        else
        {
            Debug.Log("SKILLISSUE LMAOOOOOOOO");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
