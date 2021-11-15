using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SupportController : MonoBehaviour
{

    //Variables

    public string supportType = " Bee";
    public float supportSpeed = 5f;

    //Game Object

    private GameObject player;
    

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(supportType);

        player = GameObject.Find("cat");
    }

    // Update is called once per frame
    void Update()
    {
        LookAtPlayer();
        MoveTowards(); 
    }

    //Method

    //Get Support Type
    public string GetSupportType()
    {
        return supportType;
    }
    public void SetSupportType(string newSupportType)
    {
        supportType = newSupportType;
    }

    //Follow Player
    private void MoveTowards()
    {
        Vector3 direction = (player.transform.position + new Vector3(-0.5f,0,-0.5f) - transform.position).normalized;
        transform.position += supportSpeed * Time.deltaTime * direction;
    }

    private void LookAtPlayer()
    {
        Vector3 direction = player.transform.position + new Vector3(-0.5f, 0, -0.5f) - transform.position;
        Quaternion newRotation = Quaternion.LookRotation(direction);
        transform.rotation = newRotation;
    }

}
