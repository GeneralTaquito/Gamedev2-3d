using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gamemanager : MonoBehaviour
{
    public float Timer = 90;
    public TextMeshProUGUI timeText;
    public GameObject Player;

    void Update()
    {
        Timer -= Time.deltaTime;
        timeText.text = Timer.ToString("0");
        
        if (Timer < 0)
        {
            SceneManager.LoadScene("Endgame");
        }


        
    }
}
