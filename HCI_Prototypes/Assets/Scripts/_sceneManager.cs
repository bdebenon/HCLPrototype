﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class _sceneManager : MonoBehaviour {

    public void changeScene(string sceneName)
    {
        //SceneManager.LoadScene(sceneName);
        GameManager.gManager.changeScene(sceneName);
    }
}
