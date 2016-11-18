using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{

    public GUIStyle guiStyle1 = new GUIStyle();

    void Start ()
    {
	
	}
	
	void Update ()
    {
	
	}

    public void play()
    {
        Application.LoadLevel("Jogo");
    }

    public void exit()
    {
        Application.Quit();
    }

    void OnGUI()
    {
        guiStyle1.fontSize = 40;
        guiStyle1.normal.textColor = Color.white;
        GUI.Label(new Rect(Screen.width / 2, 0, 50, 50), "" + (int)Movimento.tempo, guiStyle1);
    }
}
