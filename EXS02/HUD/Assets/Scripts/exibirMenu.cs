using UnityEngine;
using UnityEngine.UI;

public class exibirMenu : MonoBehaviour
{
    public GameObject Grid;

    public void ToggleMenu()
    {
        Grid.SetActive(!Grid.activeSelf);
    }
}
