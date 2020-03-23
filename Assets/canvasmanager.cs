using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class canvasmanager : MonoBehaviour
{
    public bool isPose = false;
    public GameObject pauseBtn;
    public GameObject pausePanel;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PausePlay()
    {
        if (isPose)
        {
            isPose = false;
            Time.timeScale = 1;
            pauseBtn.SetActive(true);
            pausePanel.SetActive(false);
        }
        else
        {
            isPose = true;
            Time.timeScale = 0;
            pauseBtn.SetActive(false);
            pausePanel.SetActive(true);
        }
    }
}
