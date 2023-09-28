using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;
    public float height = 10;


    void Update()
    {
        transform.position = target.position - transform.forward * height;
    }
}
