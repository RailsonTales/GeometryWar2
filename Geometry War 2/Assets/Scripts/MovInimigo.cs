using UnityEngine;
using System.Collections;

public class MovInimigo : MonoBehaviour
{
    
	void Start ()
    {
	
	}
	
	void Update ()
    {
        transform.position += new Vector3(-5, 0, 0) * Time.deltaTime;
    }
    
    void OnCollisionEnter2D(Collision2D colisao)
    {
        if (colisao.gameObject.tag.Contains("Bala"))
        {
            Destroy(colisao.gameObject);
        }
        if (colisao.gameObject.tag.Contains("Eliminador"))
        {
            Application.LoadLevel("Menu");
            Destroy(gameObject);
        }
        if (colisao.gameObject.tag.Contains("Jogador"))
        {
            Application.LoadLevel("Menu");
            Destroy(gameObject);
        }
    }
}
