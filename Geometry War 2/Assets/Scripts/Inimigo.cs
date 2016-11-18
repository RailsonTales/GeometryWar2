using UnityEngine;
using System.Collections;

public class Inimigo : MonoBehaviour
{

    public GameObject[] inimi;
    float count;
    bool cont;
    int ia;
    float timeInimigo;

    void Start ()
    {
        transform.position = new Vector3(10, 3.1f, 0);
	}
	
	void Update ()
    {
        if (transform.position.y > 3)
            cont = true;

        if (transform.position.y < -3)
            cont = false;

        if(cont)
            transform.position += new Vector3(0, -5, 0) * Time.deltaTime;

        if(cont == false)
            transform.position += new Vector3(0, 5, 0) * Time.deltaTime;

        count += 0.5f;
        if (count > 1f)
        {
            for (int i = 0; i < 1; i++)
            {
                Instantiate(inimi[i], transform.position + new Vector3(0f, 0f, 0f), Quaternion.identity);
            }
            count = 0;
        }
    }
}