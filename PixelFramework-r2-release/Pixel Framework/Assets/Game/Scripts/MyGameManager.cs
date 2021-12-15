using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
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
            CharacterController controller = player.GetComponent<CharacterController>();
            if (controller.IsWon())
            {
                SceneManager.LoadScene("New_1");
            } 
            else if (!controller.IsDead())
            {
                controller.Play();
                playButton.interactable = false;
            }
            else
            {
                SceneManager.LoadScene("New");
            }
        });
    }

    // Update is called once per frame
    void Update()
    {

    }
    
    
}
