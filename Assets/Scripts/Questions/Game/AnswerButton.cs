using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class AnswerButton : MonoBehaviour
{
    [SerializeField] private Button answerButton;
    [SerializeField] private TextMeshProUGUI answer;

    private Answers currentAnswer;

    public void Init(Answers answer)
    {
        currentAnswer = answer;
        this.answer.text = answer.Answer;
        answerButton.onClick.AddListener(OnClick);
    }

    private void OnClick()
    {
        if(currentAnswer.isCorrect)
            Debug.Log("Correct answer");
        else
            Debug.Log("Non correct");
        // TO DO
    }
}
