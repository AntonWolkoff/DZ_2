using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

public class Win : MonoBehaviour
{
    [SerializeField] private GameObject player;
    [SerializeField] private GameObject WinUI;
    [SerializeField] private Button playButton;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            player.GetComponent<CharacterController>().MakeWin();
            WinUI.SetActive(true);
            playButton.interactable = true;
        }
    }
}
