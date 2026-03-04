using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TargetScript : MonoBehaviour
{

    public AudioSource AR;
    
    void OnMouseDown()
    {
        transform.localScale = new Vector3(2,2,2);
        Invoke(nameof(Blowup), 0.3f);
    }

    void Blowup()
    {
        Destroy(gameObject);
        AudioSource.PlayClipAtPoint(AR.clip, transform.position);
        if (gamemanager.Instance != null)
        {
            gamemanager.Instance.AddScore(100);
        }
    }


}
