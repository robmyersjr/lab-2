using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleScript : MonoBehaviour
{
public GameObject particles;

    // Start is called before the first frame update
    void Start()
    {
     particles.SetActive(false);   
    }

    // Update is called once per frame
    void Update()

    {
      if(RespawnZone.particlesOn==true)
      {
      particles.SetActive(true);
      }
    }
}
