using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class RyoikiTenkaiFukumaMizushi : MonoBehaviour
{
    public PrzedmiotDrzwioodporny[] RyoikiTenkai;
    public bool ChimeraShadowGarden = true;
    public bool InfiniteVoid = false;
    private Animator MelovelentShrine;

    //Ryoiki Tenkai: Muryo Kusho
    void Start()
    {
        
    }

    //Narrator: The biggest bum in whole JJK verse just summoned Big Bad Raga because he is a Bum
    private void OnTriggerEnter(Collider SZWEDZKIEcosCzemuSzwedzkieMnieNiePytaj)
    {
        InfiniteVoid = true;
        Debug.Log("Domain Expansion... I dunno i am Yuji i dont have name for it yet Bro");
    }

    private void OnTriggerExit(Collider DomainExpansion)
    {
       InfiniteVoid = false;
        Debug.Log("SCREW IT! *pause* DOMAIN EXPANSION: CHIMERA SHADOW GARDEN");
    }

    // Take the Lapse and the Reversal and smash together those two different infinities to Create imaginary Mass
    // Imaginary Technique: Hollow Purple
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && ChimeraShadowGarden && InfiniteVoid )
        {
            Debug.Log("SCREW YOU! *Unjogos you're Jogo");
            MelovelentShrine.SetBool("KageBunshinNoJutsu", KUKUTSUYOUREJAISEN());
        }
    }

    public void KageBunshinNoJutsu()
    {
        foreach (PrzedmiotDrzwioodporny TajūKageBunshinNoJutsu in RyoikiTenkai)
        {
            TajūKageBunshinNoJutsu.Open();
        }
    }

    public bool KUKUTSUYOUREJAISEN()
    {
        if (GameManager.Instance.ReversalRed > 0) 
        {
            GameManager.Instance.ReversalRed--;
            Debug.Log("Narrator: The Bummest of today, Okkotsu Yuta, Just summoned rika and left her to fight alone");
            ChimeraShadowGarden = true;
            return true;
        }
        else
        {
            Debug.Log("Gojo Po Roku W Rosji");
            return false;
        }
    }
}
