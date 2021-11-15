using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    //Variables

    [SerializeField] private float playerSpeed = 10f;
    [SerializeField] private float playerHealth = 100f;

    [SerializeField] private Animator animPlayer;

    private float cameraAxis;

    

    //gameObjets

    public GameObject GuineaPigSupports;

    // Start is called before the first frame update
    void Start()
    {

        animPlayer.SetBool("isRun", false);
    }

    // Update is called once per frame
    void Update()
    {
        RotatePlayer();
        PlayerMoves();

    }

    //Methods ----------------------------->

    //Get Speed
    public float GetPlayerSpeed()
    {
        return playerSpeed;
    }
    public void SetPlayerSpeed(float newPlayerSpeed)
    {
        playerSpeed = newPlayerSpeed;
    }

  

    // Player Moves

    public void PlayerMoves()
    {
        float ejeHorizontal = Input.GetAxis("Horizontal");
        float ejeVertical = Input.GetAxis("Vertical");

        if (ejeHorizontal !=0 || ejeVertical !=0)
        {
            animPlayer.SetBool("isRun", true);
            transform.Translate(playerSpeed * Time.deltaTime * new Vector3(ejeHorizontal, 0, ejeVertical));
        }
        else
        {
            animPlayer.SetBool("isRun", false);
        }
        
    }

    //Player Rotation
    private void RotatePlayer()
    {
        cameraAxis += Input.GetAxis("Mouse X");
        Quaternion angulo = Quaternion.Euler(0f,cameraAxis,0f);
        transform.localRotation = angulo;

    }

    private void OnTriggerEnter(Collider other)
    {
        if (playerHealth > 0)
        {
            playerHealth -= 10;
        }
        else
        {
            Destroy(gameObject);
        }
    }

}
