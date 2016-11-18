using UnityEngine;
using System.Collections;

public class Boss : MonoBehaviour
{
    int cont = 0, respawn = 0;

    void Start()
    {
        respawn = 1;
    }

    void Update()
    {
        Debug.Log("Respawn: "+ respawn);
        transform.position += new Vector3(-2, 0, 0) * Time.deltaTime;

        if (cont > respawn)
        {
            transform.position = new Vector3(15, 0, 0);
            cont = 0;
            respawn += respawn;
        }
    }

    void OnCollisionEnter2D(Collision2D colisao)
    {
        if (colisao.gameObject.tag.Contains("Bala"))
        {
            Destroy(colisao.gameObject);
            cont++;
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