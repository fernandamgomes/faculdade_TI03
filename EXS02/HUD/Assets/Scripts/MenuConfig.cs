using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuConfig : MonoBehaviour
{
    [SerializeField]
    private string nomeLvlJogo;

    [SerializeField]
    private GameObject painelMenuInicial;

    [SerializeField]
    private GameObject painelOpcoes;

    private void Start() {
        painelOpcoes.SetActive(false);
    }
    public void Jogar() {
        SceneManager.LoadScene(nomeLvlJogo);
    }

    public void abrirOpcoes(){
        painelMenuInicial.SetActive(false);
        painelOpcoes.SetActive(true);
    }

    public void fecharOpcoes(){
        painelMenuInicial.SetActive(true);
        painelOpcoes.SetActive(false);
    }


}
