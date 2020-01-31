using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform character;
<<<<<<< HEAD
=======
    public Transform center;

    private Vector3 character2Center;
>>>>>>> ff4f096c4d28ee9bc1dc1b05b8330e1c2ee8274b
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.LookAt(character);
<<<<<<< HEAD
=======
        character2Center = Vector3.Normalize(new Vector3(character.transform.position.x,7.0f,character.transform.position.z) - center.transform.position);

        Debug.DrawRay(center.transform.position, character2Center*10);

        
    }

    private void LateUpdate()
    {
        this.transform.position = character.transform.position + character2Center * 5 + character2Center * character.GetComponent<CharacterLocomotion>().ReturnVelocity();
>>>>>>> ff4f096c4d28ee9bc1dc1b05b8330e1c2ee8274b
    }
}
