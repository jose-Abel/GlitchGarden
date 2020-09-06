using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealthDisplay : MonoBehaviour
{
    [SerializeField] int playerHealth = 5;

    [SerializeField] int damage = 1;

    Text playerHealthText;
    private void Start()
    {
        playerHealthText = GetComponent<Text>();

        UpdateDisplay();
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
