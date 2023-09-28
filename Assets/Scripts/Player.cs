using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public float speed = 0.01f;

    public Vector3 spawnPoint;

    private void Start()
    {
        spawnPoint = transform.position;
    }

    void Update()
    {
        Vector3 moveDirection = new Vector3();
        moveDirection.x = Input.GetAxisRaw("Horizontal");
        moveDirection.z = Input.GetAxisRaw("Vertical");

        //transform.position += moveDirection * speed * Time.deltaTime;
        GetComponent<Rigidbody>().velocity = moveDirection * speed;
        
        if(moveDirection != Vector3.zero)transform.forward = moveDirection; // rotates player to awsd direction
    }

    public void Die()
    {
        var sceneNow = SceneManager.GetActiveScene().name;
        SceneManager.LoadScene(sceneNow);
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.name.Contains("Enemy"))
        {
            Die();
        }
    }
}
