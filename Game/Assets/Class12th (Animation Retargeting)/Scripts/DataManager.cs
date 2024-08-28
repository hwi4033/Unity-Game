using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataManager : MonoBehaviour
{
    [SerializeField] int score;
    [SerializeField] ScoreUI scoreUI;

    // Start is called before the first frame update
    void Awake()
    {
        Load();
    }

    public void Initialized()
    {
        PlayerPrefs.DeleteAll();

        Load();
    }

    public void IncreaseScore()
    {
        int random = Random.Range(5, 10);

        score += random;

        scoreUI.OnUpdate(random);

        PlayerPrefs.SetInt("Score", score);
    }

    public void Load()
    {
        score = PlayerPrefs.GetInt("Score");
    }

    public void Save()
    {
        PlayerPrefs.Save();
    }
}
