using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    [SerializeField]
    private float speed = 4f;

    private bool isEnd = false;
    private Transform start = null;
    private Transform end = null;
    private Transform enemy = null;

    void Start()
    {
        getTransformAllChilds("StartPosition", "EndPosition", "EnemyBall");
    }

    void Update()
    {
        if (!isEnd)
        {
            enemy.position = Vector3.MoveTowards(enemy.position, end.position, speed * Time.deltaTime);
            if (enemy.position == end.position)
                isEnd = true;
        }
        else
        {
            enemy.position = Vector3.MoveTowards(enemy.position, start.position, speed * Time.deltaTime);
            if (enemy.position == start.position)
                isEnd = false;
        }
    }

    void getTransformAllChilds(string nameStart, string nameEnd, string nameEnemy)
    {
        Transform[] childrens = transform.GetComponentsInChildren<Transform>();

        foreach (Transform child in childrens)
        {
            if (child.name == nameStart)
                start = child;
            else if (child.name == nameEnd)
                end = child;
            else if (child.name == nameEnemy)
                enemy = child;
        }
    }
}
