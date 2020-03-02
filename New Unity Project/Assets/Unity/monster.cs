using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class monster : MonoBehaviour
{
    public Button but;

    private void Start()
    {
        but.onClick.AddListener(GameOver);           // 觸發按鈕啟動監聽者
    }

    public void GameOver()
    {
        SceneManager.LoadScene(0);
    }
}
