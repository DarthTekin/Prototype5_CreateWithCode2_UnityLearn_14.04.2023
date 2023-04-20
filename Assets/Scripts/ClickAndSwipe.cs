using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(TrailRenderer), typeof(BoxCollider))]

public class ClickAndSwipe : MonoBehaviour
{
    private bool swiping = false;

    private Vector3 mousePos;

    private GameManager gameManager;
    private Camera cam;
    private TrailRenderer trail;
    private BoxCollider col;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
