using UnityEngine;

[System.Serializable]
[CreateAssetMenu(fileName = "QuestionsSO", menuName = "Question")]
public class QuestionsSO : ScriptableObject
{
    public Question[] Questions;
}