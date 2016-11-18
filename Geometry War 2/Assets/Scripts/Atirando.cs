using UnityEngine;
using System.Collections;

public class Atirando : MonoBehaviour
{
    
	void Start ()
    {
	
	}
	
	void Update ()
    {
        transform.position += new Vector3(10,0,0) * Time.deltaTime;
	}

    void OnCollisionEnter2D(Collision2D colisao)
    {
        if (colisao.gameObject.tag.Contains("Inimigo"))
        {
            Destroy(colisao.gameObject);
        }
        if (colisao.gameObject.tag.Contains("Eliminador"))
        {
            Destroy(gameObject);
        }
    }
}