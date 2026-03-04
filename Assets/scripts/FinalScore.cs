using TMPro;
using UnityEngine;

public class FinalScore : MonoBehaviour
{
    public TextMeshProUGUI Finalscore;

    void Awake()
    {
        Cursor.lockState = CursorLockMode.None;
    }
    void Start()
    {
        Finalscore.text = gamemanager.Scoretotal.ToString();
    }
}
