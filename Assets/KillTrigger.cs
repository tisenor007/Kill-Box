using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KillTrigger : MonoBehaviour
{
   
        
        void OnTriggerEnter()
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    

    // Update is called once per frame
    void Update()
    {

    }
}
