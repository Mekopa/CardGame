using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class StartButton : MonoBehaviour
{
    public TMP_InputField usernameInputField;
    // Start is called before the first frame update
    public void OnStartButtonClicked()
    {
        if (!string.IsNullOrEmpty(usernameInputField.text))
        {
            string username = usernameInputField.text;

            PlayerPrefs.SetString("Username", username);

            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); // TODO name of the principal scene
        }
        // TODO else show error message

    }

}
