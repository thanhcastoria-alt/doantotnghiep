
using UnityEngine;

public class FireForever : MonoBehaviour
{
    private ParticleSystem[] fireEffects;

    void Awake()
    {
        fireEffects = GetComponentsInChildren<ParticleSystem>(true);

        foreach (ParticleSystem fire in fireEffects)
        {
            var main = fire.main;

            main.loop = true;
            main.playOnAwake = true;
            main.stopAction = ParticleSystemStopAction.None;

            fire.gameObject.SetActive(true);
            fire.Play();
        }
    }
}
