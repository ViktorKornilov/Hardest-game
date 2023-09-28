using UnityEngine;
using UnityEngine.SceneManagement;

public class Teleporter : MonoBehaviour
{
    public string nextLevelName;
    
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.name.Contains("Player"))
        {
            SceneManager.LoadScene(nextLevelName);
        }
    }
}
