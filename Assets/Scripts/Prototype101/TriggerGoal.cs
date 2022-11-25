using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerGoal : MonoBehaviour
{
    public GameObject Roboter;

    public ParticleSystem playParticlesSystem;
    public ParticleSystem emitParticlesSystem;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.name + " triggered into " + gameObject.name);

        // when roboter collides with goal
        if(other.name == Roboter.name)
        {
            Debug.Log("Victory");

            // Using a ParticleSystem for emission
            EmitParticles();

            // Using a ParticleSystem with Play and Stop - play true
            PlayParticles(true);
        }

    }


    private void OnTriggerExit(Collider other)
    {
        Debug.Log(other.name + " triggered into " + gameObject.name);

        // when roboter collides with goal
        if(other.name == Roboter.name)
        {
            Debug.Log("Exit");
            
            // Using a ParticleSystem with Play and Stop - play false
            PlayParticles(false);
        }

    }

    // custom method to execute emitting of particles 
    void EmitParticles()
    {
        emitParticlesSystem.Emit(50);
    }

     // custom method to execute emitting of particles 
    void PlayParticles(bool on)
    {
        if(on)
        {
            playParticlesSystem.Play();
        }
        else if(!on)
        {
            playParticlesSystem.Stop();
        }
    }    

}