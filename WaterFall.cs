
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;

public class WaterFall : UdonSharpBehaviour
{
    ParticleSystem myParticleSystem;

    void Start()
    {
        myParticleSystem = GetComponent<ParticleSystem>();
    }

    private void Update()
    {
        if (Vector3.Angle(Vector3.down, transform.forward) <= 90f)
        {
            myParticleSystem.Play();
        }
        else
        {
            myParticleSystem.Stop();
        }
    }

    private void OnParticleCollision(GameObject other)
    {
        if (other.gameObject.name == "water")
        {
            other.gameObject.transform.localScale += new Vector3(0, 0.001f, 0);
        }
    }
}
