using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using UnityEngine.SceneManagement;

public class botoes : MonoBehaviour
{

    public void iniciar(string nomeCena)
    {
        SceneManager.LoadScene(nomeCena);
    }
}
