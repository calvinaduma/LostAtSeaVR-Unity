using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class bossScriptPost : MonoBehaviour
{
    public int index = 0;
    public int score = 0;
    private char[] correctAnswers = { 'A', 'D', 'D', 'B', 'D', 'B', 'D', 'A', 'D', 'B' };
    private GameObject[] questions;
    private GameObject finalScore;

    // Start is called before the first frame update
    void Start()
    {
        finalScore = GameObject.Find("Final");
        finalScore.SetActive(false);
        questions = new GameObject[10];
        for (int i = 0; i < 10; i++)
        {
            if (i == 0)
                questions[i] = GameObject.Find("Question");
            else
            {
                questions[i] = GameObject.Find("Question (" + i.ToString() + ")");
                questions[i].SetActive(false);
            }

        }
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void nextQuestion(string temp)
    {
        char answer = temp.ToCharArray()[0];
        if (answer == correctAnswers[index])
            score += 10;
        GameObject lastQ = questions[index];
        if (index == 0)
            lastQ = GameObject.Find("Question");
        lastQ.SetActive(false);
        index++;
        if (index < 10)
        {
            GameObject currQ = questions[index];
            currQ.SetActive(true);
        }
        else
        {
            finalScore.SetActive(true);
            finalScore.GetComponent<UnityEngine.UI.Text>().text = "You have completed the post-quiz. Score: " + score.ToString() + "/100";
        }




    }
}
