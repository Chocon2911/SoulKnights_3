using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D), typeof(CapsuleCollider2D))]
public class Player : HuyMonoBehaviour
{
    [Header("Component")]
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private CapsuleCollider2D body;
    [SerializeField] private SpriteRenderer model;

    [Header("Stat")]
    [SerializeField] private int health;
    [SerializeField] private int mana;
    [SerializeField] private int amor;
    [SerializeField] private bool isAmorRegening;
    [SerializeField] private bool isPoisoning;
    [SerializeField] private bool isBurning;

    [Header("Movement")]
    [SerializeField] private float moveSpeed;
    [SerializeField] private bool isMoving;

    //==========================================Get Set===========================================
    // Component
    public Rigidbody2D Rb { get => rb; set => rb = value; }
    public CapsuleCollider2D Body { get => body; set => body = value; }
    
    // Stat
    public int Health { get => health; set => health = value; }
    public int Mana { get => mana; set => mana = value; }
    public int Amor { get => amor; set => amor = value; }
    public bool IsAmorRegening { get => isAmorRegening; set => isAmorRegening = value; }
    public bool IsPoisoning { get => isPoisoning; set => isPoisoning = value; }
    public bool IsBurning { get => isBurning; set => isBurning = value; }

    // Movement
    public float MoveSpeed { get => moveSpeed; set => moveSpeed = value; }
    public bool IsMoving { get => isMoving; set => isMoving = value; }

    //===========================================Unity============================================
    public override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadComponent(ref this.rb, transform, "LoadRb()");
        this.LoadComponent(ref this.body, transform, "LoadBody()");
        this.LoadComponent(ref this.model, transform.Find("Model"), "LoadModel()");
    }
}
