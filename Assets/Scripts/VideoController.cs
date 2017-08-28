using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class VideoController : MonoBehaviour
{
    public GameObject playButton;
	VideoPlayer vPlayer;

    void Start()
    {
        vPlayer = GetComponent<VideoPlayer>();
    }
    void Update()
	{
        if (vPlayer.isPlaying)
        {
            playButton.SetActive(false);
        }
        else
        {
            playButton.SetActive(true);
        }
    }
}
