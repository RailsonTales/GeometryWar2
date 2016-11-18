using UnityEngine;
using System.Collections;

public class Botoes : MonoBehaviour
{
    private int auxVertical;

	void Start ()
    {
	
	}
	
	void Update ()
    {
	    if(auxVertical != 0)
        {
            transform.Translate(0, - 15 * Time.deltaTime * auxVertical, 0);
        }
	}

    public void movVertical(int direcao)
    {
        auxVertical = direcao;
    }      
    
    public void exit()
    {
        Application.LoadLevel("Menu");
        //Application.Quit();
    }  
}