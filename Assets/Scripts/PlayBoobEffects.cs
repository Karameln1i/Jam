using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayBoobEffects : MonoBehaviour
{
    [SerializeField] private ParticleSystem _particleSuction;
    [SerializeField] private ParticleSystem _boom;
    
    [SerializeField] private Figure _figure;

    public event UnityAction Exploded;

    private void OnEnable()
    {
        _figure.Collected += OnCollected;
    }

    private void OnCollected()
    {
        _figure.Collected -= OnCollected;
        _particleSuction.Play();
        StartCoroutine(PlayBoomAfterSuction());
    }

    private IEnumerator PlayBoomAfterSuction()
    {
        yield return new WaitForSeconds(_particleSuction.duration/4);
        Exploded?.Invoke();
        _boom.Play();
    }
}
