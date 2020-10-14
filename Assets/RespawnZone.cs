using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnZone : MonoBehaviour 
{
public Transform whereTo;
public GameObject respawnPoint;
public static bool particlesOn;

    // Start is called before the first frame update
    private void Start()
    {
    whereTo = respawnPoint.transform;
     particlesOn=false;   
    }

    // Update is called once per frame
    private void Update()
    {
    }
    private void OnTriggerEnter(Collider other)
{
particlesOn=true;
other.gameObject.transform.position = whereTo.position;
}

}