using System;
using UnityEngine;

public class GameInitializer : MonoBehaviour
{
    [SerializeField] private AnswerPanel answerPanel;
    private void Start()
    {
        Question[] questions = Resources.Load<QuestionsSO>(AssetPath.Questions()).Questions;
        
        Debug.Log(questions.Length);
        
        answerPanel.SetQuestions(questions);
    }
}
