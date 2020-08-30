using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefenderButton : MonoBehaviour
{
    private void OnMouseDown()
    {
        GetComponent<SpriteRenderer>().color = Color.white;
    }
}
