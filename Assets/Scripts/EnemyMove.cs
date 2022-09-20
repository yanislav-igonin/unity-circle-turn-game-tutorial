using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    [SerializeField] GameObject enemy;
    [SerializeField] float speed;

    void FixedUpdate()
    {
        transform.Translate(Vector2.right * speed * Time.deltaTime);
    }
}
