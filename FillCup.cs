
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;

public class FillCup : UdonSharpBehaviour
{
    void Start()
    {

    }

    private void OnParticleCollision(GameObject other)
    {
        Debug.Log(other.gameObject.name);
    }
}
