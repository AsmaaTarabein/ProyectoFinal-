using UnityEngine;
using UnityEngine.InputSystem;

public class MovimientoPersonaje : MonoBehaviour
{
    public float velocidad = 3;
    CharacterController control;

    void Start()
    {
        control = GetComponent<CharacterController>();
    }

    void Update()
    {
        float x = 0; //izq y derecha
        float z = 0; // arriba y atras 

        if (Keyboard.current.wKey.isPressed) z = 1;
        if (Keyboard.current.sKey.isPressed) z = -1;
        if (Keyboard.current.dKey.isPressed) x = 1;
        if (Keyboard.current.aKey.isPressed) x = -1;

        Vector3 direccion = new Vector3(x, 0, z);
        if (direccion != Vector3.zero){
            
        transform.rotation = Quaternion.LookRotation(direccion);
    }

        control.SimpleMove(direccion * velocidad);
    }
}