using UnityEngine;
using UnityEngine.Video;

public class VideoPlaneController : MonoBehaviour
{
    public VideoPlayer videoPlayer;

    private void OnEnable()
    {
        if (videoPlayer != null) videoPlayer.Play();
    }

    private void OnDisable()
    {
        if (videoPlayer != null) videoPlayer.Stop();
    }
}
