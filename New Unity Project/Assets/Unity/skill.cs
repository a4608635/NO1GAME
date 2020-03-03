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
    public void Chooseskill()
    {
        print("開始");
        //panelSkill.SetActive(false);                    // 關閉開始介面

        panelSkill.GetComponent<CanvasGroup>().alpha = 0;
        panelSkill.GetComponent<CanvasGroup>().interactable = false;
        panelSkill.GetComponent<CanvasGroup>().blocksRaycasts = false;
        
    }
}
