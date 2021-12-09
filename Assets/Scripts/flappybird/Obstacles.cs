﻿using System;
using UnityEngine;

namespace FlapyBird
{
    public class Obstacles : MonoBehaviour
    {
        private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.CompareTag("Player"))
            {
                GameManager.Instance.GameOver();
            }
        }
    }
}