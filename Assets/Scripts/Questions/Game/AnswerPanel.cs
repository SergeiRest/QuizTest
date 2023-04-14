using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnswerPanel : MonoBehaviour
{
    [SerializeField] private AnswerButton[] answerButtons;

    private Question[] questions;
    private int questionIndex = 0;
    
    public void SetQuestions(Question[] questions)
    {
        this.questions = questions;
        InitButtons();
    }

    private void InitButtons()
    {
        for (int i = 0; i < answerButtons.Length; i++)
        {
            answerButtons[i].Init(questions[questionIndex].Answers[i]);
        }
    }
}
