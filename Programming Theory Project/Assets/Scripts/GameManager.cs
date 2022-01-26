using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

// INHERITANCE
public class GameManager : MonoBehaviour
{
    // POLYMORPHISM
    public void GoToMenu() {
        SceneManager.LoadScene(0);
    }
}
