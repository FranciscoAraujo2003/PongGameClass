using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    [SerializeField] AudioSource _scoreSound;
    [SerializeField] TMP_Text _winnerText;
    [SerializeField] GameObject _GOScreen;
    [SerializeField] private int _ScoreToWin = 10;
    [SerializeField] TMP_Text _playerScoreText;
    private int _PlayerOneScore = 0;
    private int _PlayerTwoScore = 0;
    void Start()
    {
        Time.timeScale = 1;
    }

    
    public void AddScore(bool Isplayerone)
    {
        if(Isplayerone)
        {
            _PlayerOneScore += 1;
            if(_PlayerOneScore >= _ScoreToWin)
            {
                _winnerText.text = "Player 1 Wins";
                if(_GOScreen != null)
                {
                    _GOScreen.SetActive(true);
                    Time.timeScale = 0;
                }
            }
        }
        else
        {
            _PlayerTwoScore += 1;
            if(_PlayerTwoScore >= _ScoreToWin)
            {
                _winnerText.text = "Player 2 Wins";
                if (_GOScreen != null)
                {
                    _GOScreen.SetActive(true);
                    Time.timeScale = 0;
                }
            }
        }
        _scoreSound.Play();
        _playerScoreText.text = _PlayerOneScore.ToString() + ":" + _PlayerTwoScore.ToString();
    }

    public void RestartGame()
    {
        SceneManager.LoadScene("GameScene");
    }
}
