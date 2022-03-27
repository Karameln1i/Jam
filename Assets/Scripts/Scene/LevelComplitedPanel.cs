using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class LevelComplitedPanel : MonoBehaviour
{
    [SerializeField] private CanvasGroup _canvasGroup;
    [SerializeField] private float _alphaDelta;
    [SerializeField] private float _dellay;

    public event UnityAction Opened;

    public void Open()
    {
        Opened?.Invoke();
       // StartCoroutine(FadeIn());
       StartCoroutine(StartFadeInAfterTime());
    }

    private IEnumerator StartFadeInAfterTime()
    {
        yield return new WaitForSeconds(_dellay);
        StartCoroutine(FadeIn());
    }
    
    private IEnumerator FadeIn()
    {

        Debug.Log("fade");
       float alphaValue = 0;

        while (alphaValue!=1)
        {
            alphaValue += _alphaDelta;
            _canvasGroup.alpha = alphaValue;
            yield return null;
        }

 
    }
}
