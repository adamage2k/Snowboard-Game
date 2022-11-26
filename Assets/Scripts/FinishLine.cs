using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{

    [SerializeField] float finishDelay;
    [SerializeField] ParticleSystem finishEffect;

    public Vector2 currentPosition;

    void Start()
    {
        currentPosition = transform.position;
        Debug.Log(currentPosition);
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            finishEffect.Play();
            GetComponent<AudioSource>().Play();
            Invoke("ReloadScene", finishDelay);
        }
        
    }

    void ReloadScene() 
    {
        SceneManager.LoadScene(0);
    }

}
