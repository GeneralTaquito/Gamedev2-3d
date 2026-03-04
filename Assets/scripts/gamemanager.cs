using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gamemanager : MonoBehaviour
{
    public float Timer = 30;
    public TextMeshProUGUI timeText;

    public static gamemanager Instance;
    public TextMeshProUGUI ScoreNumber;
    public static int Scoretotal = 00;

    void Update()
    {
        //timer stuff
        Timer -= Time.deltaTime;
        timeText.text = Timer.ToString("0");
        
        if (Timer < 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            SceneManager.LoadScene("Endgame");
        }        
    }

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
    }
    void Start()
    {
        Scoretotal = 0;
        UpdateScore();
    }

    void UpdateScore()
    {
        //score stuff
        if (ScoreNumber != null)
        {
            ScoreNumber.text = Scoretotal.ToString();
        }
    }
    public void AddScore(int amount)
    {
        Scoretotal += amount;
        UpdateScore();
    }
}
