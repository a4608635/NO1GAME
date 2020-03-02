using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;



public class Player : MonoBehaviour
{
    [Header("速度"), Range(0, 100)]
    public float speed = 1.5f;
    [Header("跳躍高度")]
    public float speedH = 100;

    public float margin = 0.1f;

    public Rigidbody rig;
    public Animator ani;
    public GameObject gameover;          // 遊戲結束

    private Image imgCross;         // 轉場
    


    bool IsGrounded()
    {
        return Physics.Raycast(transform.position, -Vector3.up, margin);
    }


    private void Start()
    {
        rig = GetComponent<Rigidbody>();
        ani = GetComponent<Animator>();

        imgCross = GameObject.Find("轉場").GetComponent<Image>();


    }
    private void FixedUpdate()
    {
        Mono();
        Jump();

    }

    private void Mono()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            ani.SetBool("移動", true);
            print("走");
            rig.AddForce(speed, 0, 0);
        }
    }


    private void Jump()
    {
        if (Input.GetKeyDown(KeyCode.Mouse1))
        {
            ani.SetBool("跳", true);
            print("跳");
            rig.AddForce(0,speedH, 0);
        }
    }
    public IEnumerator NextLevel()
    {
        //print("載入下一關");

        for (int i = 0; i < 50; i++)
        {
            imgCross.color += new Color(0, 0, 0, 0.02f);
            yield return new WaitForSeconds(0.05f);
        }

        if (SceneManager.GetActiveScene().name.Contains("BOSS"))
        {
            SceneManager.LoadScene(0);
        }
        else
        {
            int index = SceneManager.GetActiveScene().buildIndex;
            SceneManager.LoadScene(++index);
        }


    }

    public void Dada()
    {
        gameover.SetActive(true);
    }
    /// <summary>
    /// 碰到物件執行動作
    /// </summary>
    /// <param name="other"></param>
    public void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag=="敵人")
        {
            Dada();
        }
      
        if (other.gameObject.tag=="貓")
        {
            StartCoroutine(NextLevel());
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "牆")
        {
            Dada();
        }
    }
}
