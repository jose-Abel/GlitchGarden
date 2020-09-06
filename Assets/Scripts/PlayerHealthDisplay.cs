using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealthDisplay : MonoBehaviour
{
    [SerializeField] float baseHealth = 3;

    [SerializeField] int damage = 1;

    float playerHealth;

    Text playerHealthText;

    private void Start()
    {
        playerHealth = baseHealth - PlayerPrefsController.GetDifficulty();

        playerHealthText = GetComponent<Text>();

        UpdateDisplay();

        Debug.Log("Difficulty setting currently is " + PlayerPrefsController.GetDifficulty());
    }
    private void UpdateDisplay()
    {
        playerHealthText.text = playerHealth.ToString();
    }

    public void LosingHealth()
    {
        playerHealth -= damage;
        UpdateDisplay();

        if (playerHealth <= 0)
        {
            FindObjectOfType<LevelController>().HandleLoseCondition();
        }
    }
}
