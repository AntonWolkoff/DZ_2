using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Lose : MonoBehaviour
{
    [SerializeField] private GameObject player;
    [SerializeField] private GameObject LoseUI;
    [SerializeField] private Button playButton;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            player.GetComponent<CharacterController>().MakeLose();
            LoseUI.SetActive(true);
            playButton.interactable = true;
        }
    }
}
