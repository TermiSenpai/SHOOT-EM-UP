using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseManager : MonoBehaviour
{
    [SerializeField] GameObject pauseMenu;
    [SerializeField] KeyCode pauseKeyCode;
    [SerializeField] PlayerShooting playerShooting;
    [SerializeField] AudioSource ambientSound;
    [SerializeField] MouseVisibility mouse;

    private void Start()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1.0f;

    }

    private void Update()
    {
        if (Input.GetKeyDown(pauseKeyCode))
        {
            Time.timeScale = pauseMenu.activeInHierarchy ? 1.0f : 0f;
            pauseMenu.SetActive(!pauseMenu.activeInHierarchy);
            playerShooting.SetCanShoot(pauseMenu.activeInHierarchy ? false : true);

            if (pauseMenu.activeInHierarchy)
                mouse.MouseVisible();
            else
                mouse.mouseInvisible();



            // pause the ambient sound in pause menu
            if (pauseMenu.activeInHierarchy)
                ambientSound.Pause();
            else
                ambientSound.Play();
        }
    }
}
