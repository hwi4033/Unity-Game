using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreUI : MonoBehaviour
{
    [SerializeField] Text scoreText;

    // Start is called before the first frame update
    void Awake()
    {
        scoreText = GetComponent<Text>();
    }

    public void OnUpdate(int random)
    {
        scoreText.text = "Score\n" + random.ToString();
    }
}
