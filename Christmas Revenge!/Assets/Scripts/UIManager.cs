using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
public class UIManager : MonoBehaviour
{
    [SerializeField] GameManager gameManager;
    [SerializeField] Image lifeIndicator;
    [SerializeField] Sprite[] lifesprites;
    [SerializeField] GameObject[] panelController;
    [SerializeField] TMP_Text[] dialogs;
   private void Update()
    {
        lifeIndicator.sprite = lifesprites[gameManager.lifes];
    }

    public void StarGame()
    {
        SceneManager.LoadScene(1);
    }
}
