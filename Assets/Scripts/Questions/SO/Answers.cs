using UnityEngine;

[System.Serializable]
public class Answers
{
    [field: SerializeField] public string Answer { get; private set; }
    [field: SerializeField] public bool isCorrect { get; private set; }
}
