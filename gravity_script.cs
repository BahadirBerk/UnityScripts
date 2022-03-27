using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gravity : MonoBehaviour
{
    // Start is called before the first frame update

    private CharacterController cc;
    void Start()
    {
        cc = GetComponent<CharacterController>();

    }

    // Update is called once per frame
    void Update()
    {
        cc.Move(Physics.gravity * Time.deltaTime);

    }
}