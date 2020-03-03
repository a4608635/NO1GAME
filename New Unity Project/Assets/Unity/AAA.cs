using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class AAA : MonoBehaviour
{
    public GameObject txex;
    public Player play;

    private void Start()
    {
        play = FindObjectOfType<Player>();
        aaa();
    }

    public void aaa()
    {
        StartCoroutine(Reciprocal());
    }

    // 倒數協程
    public IEnumerator Reciprocal()
    {
        txex.SetActive(true);
        Text Text = txex.GetComponent<Text>();

        for (int i = 30; i > 0; i--)
        {
            print(i);
            Text.text = i.ToString();
            yield return new WaitForSeconds(1);
        }
        play.Dada();
    }
}
