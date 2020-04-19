﻿using UnityEngine;

public class MenuNavig : MonoBehaviour {
    public GameObject welcomeText;
    public GameObject startButton;
    public GameObject restartButton;
    public GameObject gameoverText;

    public GameObject gameManager;
    public GameObject organContainer;
    public GameObject cursor;

    public void Quit() {
        Application.Quit();
    }

    public void StartGame() {
        SetMainGameActive(true);
        gameObject.SetActive(false);
    }

    public void WelcomeMenu() {
        startButton.SetActive(true);
        restartButton.SetActive(false);
        gameoverText.SetActive(false);
        welcomeText.SetActive(true);
    }

    public void EndMenu() {
        SetMainGameActive(false);
        startButton.SetActive(false);
        restartButton.SetActive(true);
        gameoverText.SetActive(true);
        welcomeText.SetActive(false);
    }

    private void SetMainGameActive(bool b) {
        CursorManager.GetInstance().gameObject.SetActive(b);
        OrganContainer.GetInstance().gameObject.SetActive(b);
        GameManager.GetInstance().gameObject.SetActive(b);
    }
}
