using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    //public spherecast _spherecast;
    PlayerController Controls;
    public float CastDistance = 10f;
    Vector2 Move;
    Vector2 Rotate;
    void Awake()
    {
        Controls = new PlayerController();

        Controls.Gameplay.Echo.performed += ctx => Echo();
        Controls.Gameplay.Move.performed += ctx => Move = ctx.ReadValue<Vector2>();
        Controls.Gameplay.Move.canceled += ctx => Move = Vector2.zero;

        Controls.Gameplay.Rotate.performed += ctx => Rotate = ctx.ReadValue<Vector2>();
        Controls.Gameplay.Rotate.canceled += ctx => Rotate = Vector2.zero;
    }
    void Echo()
    {
        
        Collider[] hits = Physics.OverlapSphere(transform.position, CastDistance);
        foreach (Collider hit in hits)
        {
            Debug.Log($"Detected: {hit.name}");

        }


 
    }

    private void Update()
    {
        Vector2 m = new Vector2(Move.x, Move.y) * Time.deltaTime;
        transform.Translate(m, Space.World);
        

        Vector2 r = new Vector2(Rotate.y, Rotate.x) * 100f * Time.deltaTime;
        transform.Rotate(r, Space.World);
    }

    private void OnEnable()
    {
        Controls.Gameplay.Enable();
    }
    private void OnDisable()
    {
        Controls.Gameplay.Disable();
    }
    void OnDrawGizmosSelected()
    {

        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, CastDistance);

    }

}