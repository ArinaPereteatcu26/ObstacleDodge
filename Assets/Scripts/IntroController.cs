using System.Collections;
using Unity.Cinemachine;
using UnityEngine;

public class IntroController : MonoBehaviour
{
    public Camera introCamera;
    public CinemachineCamera playerCam;   
    public GameObject startMessage;
    public MonoBehaviour Mover;

    public float introLength = 7.35f;
    public float startTextTime = 2f;

    private static bool hasPlayedIntro = false;

    void Start()
    {
        if (hasPlayedIntro)
        {
            introCamera.enabled = false;
            playerCam.Priority = 20;
            startMessage.SetActive(false);
            Mover.enabled = true;
            return;
        }

        hasPlayedIntro = true;

        introCamera.enabled = true;
        playerCam.Priority = 0;
        Mover.enabled = false;
        startMessage.SetActive(false);

        StartCoroutine(PlayIntro());
    }

    IEnumerator PlayIntro()
    {
        yield return new WaitForSeconds(introLength);

        introCamera.enabled = false;
        playerCam.Priority = 20;

        startMessage.SetActive(true);
        yield return new WaitForSeconds(startTextTime);
        startMessage.SetActive(false);

        Mover.enabled = true;
    }
}
