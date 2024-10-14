using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotate : MonoBehaviour
{
    [SerializeField] Vector3 startPosition;
    [SerializeField] Vector3 endPosition;
    [SerializeField] float duration = 5.0f;
    private float timer = 0.0f;
    private bool movingToEnd = true;

    void Start()
    {
        transform.position = startPosition;
    }

    void Update()
    {
        timer += Time.deltaTime;

        if (timer > duration)
        {
            timer = 0.0f;
            movingToEnd = movingToEnd == false;
        }

        float t = timer / duration;
        if (movingToEnd)
        {
            transform.position = Vector3.Lerp(startPosition, endPosition, t);
        }
        else
        {
            transform.position = Vector3.Lerp(endPosition, startPosition, t);
        }
    }
}
