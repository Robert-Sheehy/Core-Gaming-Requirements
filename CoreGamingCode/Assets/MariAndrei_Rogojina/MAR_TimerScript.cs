using UnityEngine;

public class MAR_TimerScript : MonoBehaviour
{
    private float timer;

    private float timerMax;

    private float timerMin;
    
    private bool runTimer = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        runTimer = false;
        timer = Mathf.Clamp(timer, timerMin, timerMax);

    }


    public void startTimer()
    {
        while (runTimer = true)
        {
            timer = timerMax -= Time.deltaTime;
        }
        
    }

    public void stopTimer()
    {
        if (runTimer = false)
        {
            timer = currentTime;
        }
    }

    public float currentTime
    {
        get { return timer; }
    }
}
