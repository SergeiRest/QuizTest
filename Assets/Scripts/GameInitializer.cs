using System;
using UnityEngine;

public class GameInitializer : MonoBehaviour
{
    [SerializeField] private AnswerPanel answerPanel;
    
    private void Start()
    {
        Question[] questions = Resources.Load<QuestionsSO>(AssetPath.Questions()).Questions;
        SettingsSO settings = Resources.Load<SettingsSO>(AssetPath.Settings());
        
        Settings.Init(settings);
        
        answerPanel.SetQuestions(questions);
    }
}
