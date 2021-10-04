using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class StartSceneBUttons : MonoBehaviour
{
    public void OnPlayButtonPressed()
    {
        SceneManager.LoadScene("Main");
    }
    public void OnInstructionButtonPressed()
    {
        SceneManager.LoadScene("Instructions");
    }
}
