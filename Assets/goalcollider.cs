using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static playercontroller;
using UnityEngine.SceneManagement;

public class goalcollider : MonoBehaviour
{
    public Color[] colors;
    private Renderer goalRenderer;
    private Color currentColor;

    void Start()
    {
        goalRenderer = GetComponent<Renderer>();
        ChangeColor();
    }

    public void ChangeColor()
    {
        currentColor = colors[Random.Range(3, colors.Length)];
        goalRenderer.material.color = currentColor;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            PlayerController player = other.GetComponent<PlayerController>();
            if (player != null)
            {
                player.ChangeColor(currentColor); // Change player color to match goal
                ChangeColor(); // Change goal color for next level

            }
        }
    }

}

