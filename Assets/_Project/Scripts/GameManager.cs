using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField] private Slider countdownBar;
    [SerializeField] private float countdownTime;
    [SerializeField] private TMP_Text countdownText;

    private float _time;

    private void Start()
    {
        _time = countdownTime;
        countdownBar.maxValue = _time;
        countdownBar.value = _time;
        countdownText.text = _time.ToString("0.0");
    }

    private void Update()
    {
        if (_time >= 0)
        {
            _time -= Time.deltaTime;
            countdownBar.value = _time;
            countdownText.text = _time.ToString("0.0");
        }
        else
        {
            Debug.Log("kill player");
        }
    }
}
