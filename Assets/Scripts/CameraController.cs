using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform character;
    public Transform center;

    private Vector3 character2Center;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.LookAt(character);
        character2Center = Vector3.Normalize(new Vector3(character.transform.position.x,7.0f,character.transform.position.z) - center.transform.position);

        Debug.DrawRay(center.transform.position, character2Center*10);

        
    }

    private void LateUpdate()
    {
        this.transform.position = character.transform.position + character2Center * 5 + character2Center * character.GetComponent<CharacterLocomotion>().ReturnVelocity();
    }
}
