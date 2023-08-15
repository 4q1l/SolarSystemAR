using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KumpulanSuara : MonoBehaviour
{
    public static KumpulanSuara instance;

    public AudioClip[] CLipNya;

   List<AudioSource> Suara = new List<AudioSource>();
    private void Awake()
    {
        instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        Suara.Clear();
        for (int i = 0; i < CLipNya.Length; i++)
        {
            Suara.Add(gameObject.AddComponent<AudioSource>());
            Suara[i].clip = CLipNya[i]; 
        }
    }

    public void Panggil_Suara(int i)
    {
        Suara[i].Play();
    }

}
