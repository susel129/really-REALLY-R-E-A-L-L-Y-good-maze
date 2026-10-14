using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static KukutsuJaisen;

public class GameManager : MonoBehaviour
{

    public static GameManager INSTANCJA;
    [SerializeField] int ZeitZumSchloss;
    bool iDunnoMaybeeeeeAPAP = false;
    bool iToldYaToEatAPAPnOWyOUREdEAD = false;
    bool BRAVOyOUaTEaPAP = false;

    public int Food = 0;
    public int ReversalRed = 0;
    public int LapseBlue = 0;
    public int HollowPurple = 0;

    public void MehrEssen(int ZEIT)
    {
        Food += ZEIT;
    }

    public void MehrZEIT(int ZEIT)
    {
        ZeitZumSchloss += ZEIT;
    }








    // Usless Text like Useless Miwa
    void Start()
    {
        if (INSTANCJA == null)
        {
            INSTANCJA = this;
        }

        if (ZeitZumSchloss <= 0)
        {
            ZeitZumSchloss = 100;
        }

        InvokeRepeating("APAPAPAPAPAPAPAPAAPAPPAPAPPAPAnoc", 1, 1);
        Debug.Log("Rechte Zeit: " + ZeitZumSchloss);
    }

    void APAPAPAPAPAPAPAPAAPAPPAPAPPAPAnoc()
    {
        ZeitZumSchloss--;
        if (ZeitZumSchloss <= 0)
        {
            ZeitZumSchloss = 0;
            iToldYaToEatAPAPnOWyOUREdEAD = true;
        }

        if (iToldYaToEatAPAPnOWyOUREdEAD)
        {

        }

        Debug.Log("Rechte Zeit: " + ZeitZumSchloss);
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

    public void APAPnoC()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (iDunnoMaybeeeeeAPAP)
            {
                DankeDirFurSpielen();

                Cursor.lockState = CursorLockMode.Locked;
            }
            else
            {
                IchBitteDichStoppeDieseSpielNicht();

                Cursor.lockState = CursorLockMode.Confined;
            }
        }
    }

    public Text FrickinLoserLMFAO;
    public GameObject Byakugan;

    public void ScwipinwIwHawd()
    {
        if (BRAVOyOUaTEaPAP)
        {
            FrickinLoserLMFAO.text = "CURSE YOU!"; 
            Debug.Log("FRICK, YOU WON");
        }
        else
        {
            FrickinLoserLMFAO.text = "Frickin' Loser LMFAO";
            Debug.Log("SKILLISSUE LMFAOOOOOOOO");
        }
    }

    public void einApapNacht()
    {
        if (Input.GetKeyDown(KeyCode.O))
        {
            Debug.Log("Actual time: " + ZeitZumSchloss);
            Debug.Log("ESSEN: " + Food);
            Debug.Log("AQUIRED HOLLOW PURPLE, PURPLE AMOUNT: " + HollowPurple);
            Debug.Log("AQUIRED RED, RED AMOUNT: " + ReversalRed);
            Debug.Log("AQUIRED BLUE, BLUE AMOUNT: " + LapseBlue);
        }
    }

    // Update is called once per frame
    void Update()
    {
        einApapNacht();
        
        APAPnoC();
    }

    public Text SuperMegaTextI;
    public Text SuperMegaTextII;
    public Text SuperMegaTextIII;

    public void KillSorcererEqualsEarningPointWELLLLLLLLTheseAreTheCullingGamesRules(int OKARUN)
    {

        Food += OKARUN;
    }

    public void WIECEJCZASU(int AvadaCadavra)
    {
        ZeitZumSchloss += AvadaCadavra;
    }

    public void Bigos(KukutsuJaisenn MultipleShadowCloneJutsu)
    {
        if (MultipleShadowCloneJutsu == KukutsuJaisenn.JujutsuKaisen)
        {
            LapseBlue++;
        }
        else if (MultipleShadowCloneJutsu == KukutsuJaisenn.KukutsuJaisen)
        {
            ReversalRed++;
        }
        else if (MultipleShadowCloneJutsu == KukutsuJaisenn.JukutsuJaisen)
        {
            HollowPurple++;
        }

    }
}
