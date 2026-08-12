using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pieróg : OgólneŻarełko
{
    public int ESSEN = 5;

    public override void Zapapiono()
    {
        GameManager.Instance.MehrEssen(ESSEN);
        Debug.Log("ALEALEALEALEALEALEALEALE ALE ALE ALE  ALE  ALE  ALE   ALE podniosłeś pickup 👍");
        Destroy(this.gameObject);
    }
}
