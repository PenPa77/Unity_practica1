using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public static float maxTime = 2.0f;
    public static float countDown = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        countDown = maxTime;
    }

    // Update is called once per frame
    void Update()
    {
        countDown -= Time.deltaTime;
        
        if(countDown <= 0)
        {
            
            string currentSceneName = SceneManager.GetActiveScene().name;
            SceneManager.LoadScene(currentSceneName);
        }
    }
}
