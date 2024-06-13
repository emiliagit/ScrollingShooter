using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fondo : MonoBehaviour
{
    [SerializeField] private Vector2 velocidadMovimiento;

    private Vector2 offset;

    private Material material;

    //private Transform playerTransform;

   



    private void Awake()
    {
        material = GetComponent<SpriteRenderer>().material;

    }

    private void Start()
    {

    }

    private void Update()
    {
        
    }

    private void FixedUpdate()
    {
        offset = velocidadMovimiento * Time.deltaTime;
        material.mainTextureOffset += offset;
    }

}
