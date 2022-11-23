using UnityEngine;

public class Audio : MonoBehaviour,IFinishGameListener
{
    [SerializeField] private AudioSource _finishSong;

    public void OnFinishGame()
    {
        _finishSong.Play();
    }
}
