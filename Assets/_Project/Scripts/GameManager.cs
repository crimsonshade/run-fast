using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [Header("Countdown")]
    [SerializeField] private Slider   countdownBar;
    [SerializeField] private float    countdownTime;
    [SerializeField] private TMP_Text countdownText;

    [Header("Screens")] 
    [SerializeField] private GameObject deadScreen;

    private float _time;
    private PlayerMovement _player;

    private void Awake()
    {
        _player = FindObjectOfType<PlayerMovement>();
    }

    private void Start()
    {
        _time = countdownTime;
        countdownBar.maxValue = _time;
        countdownBar.value = _time;
        countdownText.text = _time.ToString("0.0");
        
        deadScreen.SetActive(false);
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
            _player.KillPlayer();
            deadScreen.SetActive(true);
        }
    }

    public void AddTime(float time)
    {
        _time += time;
    }
}
