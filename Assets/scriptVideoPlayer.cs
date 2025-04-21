using UnityEngine;
using UnityEngine.Video;
using UnityEngine.SceneManagement;

public class scriptVideoPlayer : MonoBehaviour
{
    public VideoPlayer videoPlayer;

    void Start()
    {
        videoPlayer.loopPointReached += OnVideoEnd;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) || Input.GetKeyDown(KeyCode.Space))
        {
            SceneManager.LoadScene("SampleScene");
        }
    }

    void OnVideoEnd(VideoPlayer vp)
    {
        SceneManager.LoadScene("SampleScene"); 
    }
}
