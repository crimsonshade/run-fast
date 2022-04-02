using System;
using UnityEngine;
using UnityEngine.UIElements;

public class PointsAnimation : MonoBehaviour
{
    [SerializeField] private float floatStrength;
    
    private Vector2 _floatY;
    private float originalY;
    
    private void Start()
    {
        this.originalY = this.transform.position.y;
    }

    private void Update()
    {
        transform.position = new Vector3(transform.position.x, originalY + ((float)Math.Sin(Time.time) * floatStrength), transform.position.z);
    }
}
