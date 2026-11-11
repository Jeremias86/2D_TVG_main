using UnityEngine;
using TMPro;
using System;

public class PlayerHealth : MonoBehaviour
{
    public int health = 100;
    public TMP_Text healthText;

    internal void Heal(int healAmount)
    {
        throw new NotImplementedException();
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        healthText.text = "Health: " + health;
    }

    // Update is called once per frame
    void Update()
    {
        healthText.text = "Health: " + health;
    }
}