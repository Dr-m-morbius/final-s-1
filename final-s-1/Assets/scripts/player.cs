using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public float speed = 10f;

    private float _horizontalInput;
    private float _verticalInput;

    private Rigidbody _playerRB;
    // Start is called before the first frame update
    void Start()
    {
        _playerRB = GetComponent<Rigidbody>();              
    }

    // Update is called once per frame
    void Update()
    {
        _horizontalInput = Input.GetAxis("Horizontal");
        _verticalInput = Input.GetAxis("Vertical");

        Vector3 lookDirection = new Vector3(_horizontalInput, 0f, _verticalInput);

        _playerRB.AddForce(lookDirection * speed);
    }
}
