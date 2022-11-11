using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerDecoy : MonoBehaviour
{
    public GameObject Roboter;
    public AudioClip decoySFX;
    private AudioSource _audioSource;

    void Start()
    {
        _audioSource = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.name + " triggered into " + gameObject.name);

        // when roboter collides with decoy
        if(other.name == Roboter.name)
        {
            //Debug.Log("REACHED DECOY");

            _audioSource.PlayOneShot(decoySFX, 1f);

            // two ways to remove a game object - destroy destories the whole game object, setactive just disables the object
            Destroy(gameObject,1f);
            // gameObject.SetActive(false);
        }

    }
}
