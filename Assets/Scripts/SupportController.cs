using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SupportController : MonoBehaviour
{

    //Variables

    [SerializeField] private string supportType = " Bee";

    [SerializeField] private float supportSpeed = 10f;

    //Game Object

    private GameObject Player;
    

    // Start is called before the first frame update
    void Start()
    {

        Player = GameObject.Find("Player");
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
        Vector3 direction = (Player.transform.position + new Vector3(-0.5f, 1f, 0f) - transform.position).normalized;
        transform.position += supportSpeed * Time.deltaTime * direction;
    }

    private void LookAtPlayer()
    {
        Vector3 direction = Player.transform.position + new Vector3(-0.5f, 1f, 0f) - transform.position;
        Quaternion newRotation = Quaternion.LookRotation(direction);
        transform.rotation = newRotation;
    }

}
