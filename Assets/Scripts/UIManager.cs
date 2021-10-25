using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public static UIManager instance { get; private set; } = null;

    public Text _timerText = null;

    private Text timerText { get { return _timerText; } set { _timerText = value; } }

    public void Awake()
    {
        instance = this;
    }

    void Update()
    {
        
    }

    public void SetTimer(float time)
    {
        timerText.text = "Timer: " + time.ToString("F2");
    }
}
