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
    void Awake()
    {
        cam = Camera.main;
        trail = GetComponent<TrailRenderer>();
        col = GetComponent<BoxCollider>();
        trail.enabled = false;
        col.enabled = false;
        gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void UpdateMousePosition()
    {
        mousePos = cam.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, -10.0f));
        transform.position = mousePos;
    }
}
