using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PortaScene : MonoBehaviour
{
    public GameObject PlayerObj;
    public string scenaName;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "Player")
        {
            Debug.Log("Player");
            SceneManager.LoadScene(scenaName);
            DontDestroyOnLoad(PlayerObj);
        }
    }
}
