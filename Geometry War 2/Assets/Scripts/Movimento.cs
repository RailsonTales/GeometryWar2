using UnityEngine;
using System.Collections;

public class Movimento : MonoBehaviour
{
    public float velocidade;
    private Vector3 ajusteposicao;
    public GameObject bala;
    float count;
    public static float tempo;
    public GUIStyle guiStyle1 = new GUIStyle();

    void Start ()
    {
        velocidade = 15.0f;
        ajusteposicao = new Vector3(0f, 0f, 0f);
        tempo = 0;
    }

    void Update()
    {
        tempo += Time.deltaTime;
        Debug.Log("Tempo: " + tempo);

        if (Input.GetAxisRaw("Vertical") > 0)
            transform.Translate(Vector2.up * velocidade * Time.deltaTime);

        if (Input.GetAxisRaw("Vertical") < 0)
            transform.Translate(-Vector2.up * velocidade * Time.deltaTime);

        if (transform.position.y > 4)
            transform.position = new Vector3(-8, 4, 0);

        if (transform.position.y < -4)
            transform.position = new Vector3(-8, -4, 0);

        count += 0.5f;
        if (count > 1)
        {
            Instantiate(bala, transform.position + new Vector3(1f, 0f, 0f), Quaternion.identity);
            count = 0;
        }
    }

    void OnGUI()
    {
        guiStyle1.fontSize = 40;
        guiStyle1.normal.textColor = Color.white;
        GUI.Label(new Rect(Screen.width/2, 0, 50, 50), "" + (int)tempo, guiStyle1);
    }
}