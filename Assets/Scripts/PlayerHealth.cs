using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerHealth : MonoBehaviour
{
    private void OnTriggerEnter2D()
    {
      FindObjectOfType<PlayerHealthDisplay>().LosingHealth();
    }
}
