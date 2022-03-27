using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class LevelComplitedPanel : MonoBehaviour
{
    [SerializeField] private Animation _animation;

    public event UnityAction Opened;

    public void Open()
    {
        Opened?.Invoke();
        StartCoroutine(PlayOpenAnimationAfterTime());
    }

    private IEnumerator PlayOpenAnimationAfterTime()
    {
        yield return new WaitForSeconds(1f);
        _animation.Play();
    }
}
