
using UnityEngine;
using UnityEngine.SceneManagement;

public class VictoryPanel : MonoBehaviour
{
    [SerializeField] private GameObject victoryPanel;
    [SerializeField] private string menuPrincipal = "Menu";

    private bool win = false;

    void Start()
    {
        victoryPanel.SetActive(false);
        Time.timeScale = 1;
    }

    public void MostrarVitoria()
    {
        if (win) return;

        win = true;
        victoryPanel.SetActive(true);

        // Pausa o jogo enquanto a tela está aberta
        Time.timeScale = 0;
    }

    public void VoltarAoMenu()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(menuPrincipal);
    }
}
