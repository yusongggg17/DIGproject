using UnityEditor;
using UnityEngine;

public class EndGameManager : MonoBehaviour
{
    //public GameObject pauseMenu;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy")) {
            //Time.timeScale = 0f;
            //pauseMenu.SetActive(true);
            EditorApplication.isPlaying = false; 
        }
    }
}
