using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CharacterSelect : MonoBehaviour
{
    public void LoadCharacterMenu()
    {
        SceneManager.LoadScene("CharacterSelection");
    }
}
