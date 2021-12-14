using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MyGameManager : MonoBehaviour
{
    [SerializeField] private Button playButton;

    [SerializeField] private GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        playButton.onClick.AddListener(() =>
        {
            player.GetComponent<CharacterController>().Play();
            playButton.interactable = false;
        });
    }

    // Update is called once per frame
    void Update()
    {

    }
    
    
}
