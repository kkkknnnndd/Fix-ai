using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponAttribute : MonoBehaviour
{
    public AttributesManager atm;
    private AudioManager audioManager;
    public int damageAmount = 20;
    private void Awake()
    {
        audioManager = GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioManager>();
    }

    private void OnTriggerEnter(Collider other)
    {
        Destroy(transform.GetComponent<Rigidbody>());
        if (other.CompareTag("Enemy"))
        {
            other.GetComponent<Dragon>().TakeDamage1(damageAmount);
            audioManager.PlaySFX(audioManager.enemyImpact);
        }    
    }
}
