using UnityEngine;

public class CameraControl : MonoBehaviour
{
    [Header("速度"), Range(0, 100)]
    public float speed = 1.5F;

    private Transform player;

    private void Start()
    {
        player = GameObject.Find("貓").transform;
    }

    private void Update()
    {
        
    }

    private void Track()
    {
        Vector3 posP = player.position;
        Vector3 posC = transform.position;

        transform.position = Vector3.Lerp(posC, posP, 0.3f * Time.deltaTime * speed);
    }
}
