using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WolfEnemyController : MonoBehaviour
{


    [SerializeField] private float wolfWatchRange = 5f;
    [SerializeField] private GameObject wolfWatchOrigin;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        RaycastWolfEnemy(); 
    }
    private void RaycastWolfEnemy()
    {
        RaycastHit hit;
        if (Physics.Raycast(wolfWatchOrigin.transform.position, wolfWatchOrigin.transform.TransformDirection(Vector3.forward), out hit, wolfWatchRange))
        {
            Debug.Log("Te vieron!!");
        }
    }
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawRay(wolfWatchOrigin.transform.position, wolfWatchOrigin.transform.TransformDirection(Vector3.forward) * wolfWatchRange);
    }
}
