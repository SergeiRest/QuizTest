using System.Collections;
using TMPro;
using UnityEngine;

public class AnswerPanel : MonoBehaviour
{
    [SerializeField] private AnswerButton[] answerButtons;
    [SerializeField] private TextMeshProUGUI question;
    [SerializeField] private TextMeshProUGUI questionIndexText;

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
            answerButtons[i].Click += () => StartCoroutine(HideAll());
        }

        question.text = questions[questionIndex].Description;
        questionIndex++;
        questionIndexText.text = $"{questionIndex}/{questions.Length}";
    }

    private IEnumerator HideAll()
    {
        foreach (var button in answerButtons)
        {
            button.Animator.Hide();
            button.Click = null;
        }
        
        yield return new WaitForSecondsRealtime(Settings.ButtonHideDuration);
        InitButtons();
    }
}
