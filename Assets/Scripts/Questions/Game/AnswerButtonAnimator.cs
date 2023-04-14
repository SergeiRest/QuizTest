using System;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class AnswerButtonAnimator : MonoBehaviour
{
    private Vector3 defaultScale = Vector3.one;

    public void Hide()
    {
        transform.DOScale(Vector3.zero, Settings.ButtonHideDuration).OnComplete(() =>
        {
            Show();
        });
    }

    private void Show()
    {
        transform.DOScale(defaultScale, Settings.ButtonShowDuration);
    }
}
