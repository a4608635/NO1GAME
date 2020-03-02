using UnityEngine.UI;
using UnityEngine;

public class skill : MonoBehaviour
{
    private Button but;                 // 按鈕
    private GameObject panelSkill;      // 開始介面

    private void Start()
    {
        but = GetComponent<Button>();                   // 讀取按鈕
        panelSkill = GameObject. Find("開始介面");      // 讀取開始介面
        but.onClick.AddListener(Chooseskill);           // 觸發按鈕啟動監聽者
        
    }
    /// <summary>
    /// 關閉開始介面
    /// </summary>
    private void Chooseskill()
    {
        print("開始");
        panelSkill.SetActive(false);                    // 關閉開始介面
    }
}
