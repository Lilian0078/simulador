using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class paineis : MonoBehaviour
{
    public GameObject painelInfo;
    public bool acaoBotao;
    void Start()
    {
        acaoBotao = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (acaoBotao == true)
        {
            painelInfo.SetActive(true);
            
        } else if (acaoBotao == false)
        {
            painelInfo.SetActive(false);
        }
    }

    public void adicionarPainel()
    {
        acaoBotao=!acaoBotao;
    }
}
