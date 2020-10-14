using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Press W to load the next level 
        if (Input.GetKeyDown(KeyCode.W)){
        Debug.Log("GENERAL KENOBI!");
        SceneManager.LoadScene(1);

        }

        
    }
}
