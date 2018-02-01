using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGMover : MonoBehaviour
{
    public float scrollSpeed;
    public float tileSizez;

    private Vector3 startPosition;

	void Start ()
    {
        startPosition = transform.position;
	}

	void Update ()
    {
        float newposition = Mathf.Repeat(Time.time * scrollSpeed, tileSizez);
        transform.position = startPosition + Vector3.forward * newposition;
	}
}
