using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerDetector : MonoBehaviour
{
    private bool playerIn;
    public GameObject objectToShow;
    public GameObject loadingText;
    public string sceneToLoad;
    void Start()
    {
        
    }

    void Update()
    {
        if(playerIn)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                loadingText.SetActive(true);
                SceneManager.LoadScene(sceneToLoad, LoadSceneMode.Single);
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            objectToShow.SetActive(true);
            playerIn = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            objectToShow.SetActive(false);
            playerIn = false;
        }
    }
}
