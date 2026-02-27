using System;
using UnityEngine;

public class TargetScript : MonoBehaviour
{
    void OnMouseDown()
    {
        transform.localScale = new Vector3(2,2,2);
        Invoke(nameof(Blowup), 0.6f);
    }

    void Blowup()
    {
        Destroy(gameObject);
    }


}
