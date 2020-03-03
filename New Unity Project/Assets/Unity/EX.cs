using UnityEngine.UI;
using UnityEngine;
using System.Collections;

public class EX : MonoBehaviour
{
    public Button but;
    private void Start()
    {
        but.onClick.AddListener(GameQuit);
    }

    public void GameQuit()
    {
        Application.Quit();
    }
}
