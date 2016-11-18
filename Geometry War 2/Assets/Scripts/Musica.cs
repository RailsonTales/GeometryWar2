using UnityEngine;
using System.Collections;

public class Musica : MonoBehaviour
{
    public Texture2D musicOn;
    public Texture2D musicOff;
    public bool ativo;
    AudioSource a;
    GUITexture b;

    void Start ()
    {
        a = GetComponent<AudioSource>();
        b = GetComponent<GUITexture>();
	}
	
	void Update ()
    {
        if (ativo)
        {
            a.mute = false;
            b.texture = musicOn;
        }
        else
        {
            a.mute = true;
            b.texture = musicOff;
        }
    }
    void OnMouseDown()
    {
        ativo = !ativo;
    }
}
