using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Vector3 speed;

    private void Update()
    {
        transform.position += speed * Time.deltaTime;
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.name == "Ground") return;
        
        speed = -speed;
    }
}
