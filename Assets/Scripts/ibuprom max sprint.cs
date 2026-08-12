using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ibuprommaxsprint : OgólneŻarełko
{
    public int ZEIT = 5;

    public override void Zapapiono()
    {
        GameManager.Instance.MehrZEIT(ZEIT);
        Debug.Log("ALEALEALEALEALEALEALEALE ALE ALE ALE  ALE  ALE  ALE   ALE podniosłeś pickup 👍");
        Destroy(this.gameObject);
    }
}
