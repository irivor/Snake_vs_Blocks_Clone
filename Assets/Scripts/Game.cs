using UnityEngine;
using UnityEngine.SceneManagement;

public class Game : MonoBehaviour
{
    public Player Controls;
    public GameObject Loss;

    public enum State
    {
        Playing,
        Win,
        Loss,
    }

    public State CurrentState { get; private set; }

    public void OnPlayerDied()
    {
        if (CurrentState != State.Playing) return;
        CurrentState = State.Loss;
        Controls.enabled = false;
        Debug.Log("Game Over!");
        Loss.SetActive(true);
    }

    public void OnPlayerWin()
    {
        if (CurrentState != State.Playing) return;
        CurrentState = State.Win;
        Controls.enabled = false;
        Debug.Log("You Win! Congratulations");
    }

}
