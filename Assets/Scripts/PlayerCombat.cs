using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCombat : MonoBehaviour
{
    public ParticleSystem[] hitParticles;

    private void OnTriggerEnter(Collider other)
    {
        var hit = other.gameObject.GetComponent<Enemy>();

        if (hit != null)
        {
            hit.GetHit();
            foreach (var hitParticle in hitParticles)
            {
                hitParticle.Play();
            }

            hit.gameObject.SetActive(false);
                
        }
    }
}
