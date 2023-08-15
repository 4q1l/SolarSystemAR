using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FUngsiSentuhPlanet : MonoBehaviour
{
    private void OnMouseDown()
    {
        GetComponent<Animation>().Play("button");
        Sistem.instance.PanggilSuaraPlanet();

    }
}
