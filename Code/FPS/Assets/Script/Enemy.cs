using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField]
    Transform[] targets;
    int targetIndex;
    Transform currentTarget;

    [SerializeField]
    float speed;

    [SerializeField]
    float dis;

    // Start is called before the first frame update
    void Start()
    {
        UpdataTarget();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.Lerp(transform.position, currentTarget.position, speed * Time.deltaTime);
        
        if(Vector3.Distance(transform.position, currentTarget.position) < dis)
        {
            targetIndex++;
            if(targetIndex >= targets.Length)
            {
                targetIndex = 0;
            }
            UpdataTarget();
        }
    }

    void UpdataTarget()
    {
        currentTarget = targets[targetIndex];
    }
}
