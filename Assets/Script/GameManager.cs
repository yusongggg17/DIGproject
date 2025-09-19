using UnityEditor;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    //public GameObject pauseMenu;
    public GameObject Level3Enemy;
    public GameObject Congrats;
    public GameObject ThankYouClip;
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
        //End Game
        if (collision.gameObject.CompareTag("Enemy"))
        {
            //Time.timeScale = 0f;
            //pauseMenu.SetActive(true);
            EditorApplication.isPlaying = false;
        }
        //Activate level 3 enemy
        else if (collision.gameObject.CompareTag("Level3"))
        {
            Level3Enemy.SetActive(true);
        } 
        else if (collision.gameObject.CompareTag("ExitLevel3"))
        {
                Level3Enemy.SetActive(false);
                Congrats.SetActive(true);
        }
        else if (collision.gameObject.CompareTag("NiceWords")) {
            ThankYouClip.SetActive(true);
        }
    }
    private void OnCollisionExit(Collision collision) {
     if (collision.gameObject.CompareTag("NiceWords"))
        {

            //if (ThankYouClip != null && !ThankYouClip.isPlaying) 
            //{
            //    ThankYouClip.Play();
            //}
            ThankYouClip.SetActive(false);

        }
    }
}
