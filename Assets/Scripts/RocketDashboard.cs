using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;


public class RocketDashboard : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI currentScoreTxt;
    [SerializeField] private TextMeshProUGUI HighScoreTxt;

    private int score = 0;
    public static int highScore;
    private float trans = 0f;
    [SerializeField] private Rigidbody2D _rb2d;

    private void Awake()
    {
        
    }

    public void Update() 
    {
        if (trans >= 0)
        {
            trans = _rb2d.transform.position.y;
            score += (int)trans;

            if (highScore < score)
            {
                highScore = score;
            }

            currentScoreTxt.text = $"Score : {score} M";
            HighScoreTxt.text = $"High : {score} M";
        }
    }


    public void Retry()
    {
        SceneManager.LoadScene(0);
    }
}

