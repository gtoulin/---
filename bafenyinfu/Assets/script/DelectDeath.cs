using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DelectDeath : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTiggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player"){
            SceneManager.LoadScene(0);
        }
    }
}
