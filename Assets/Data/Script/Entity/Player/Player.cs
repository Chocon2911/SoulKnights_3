using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D), typeof(CapsuleCollider2D))]
public class Player : HuyMonoBehaviour
{
    [SerializeField] private float speed; 

    [Header("Component")]
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private CapsuleCollider2D body;
    [SerializeField] private SpriteRenderer model;

    [Header("Stat")]
    [SerializeField] private int maxHealth;
    [SerializeField] private int health;
    [SerializeField] private int maxMana;
    [SerializeField] private int mana;
    [SerializeField] private int maxAmor;
    [SerializeField] private int amor;
    [SerializeField] private bool isDamaging;
    [SerializeField] private bool isPoisoning;
    [SerializeField] private bool isBurning;

    [Header("Movement")]
    [SerializeField] private bool isMoving;

    [Header("Dash")]
    [SerializeField] private bool isDashing;

    [Header("Amor Regen")]
    [SerializeField] private bool isRegeningAmor;

    //==========================================Get Set===========================================
    // Component
    public Rigidbody2D Rb { get => rb; set => rb = value; }
    public CapsuleCollider2D Body { get => body; set => body = value; }
    public SpriteRenderer Model { get => model; set => model = value; }

    // Stat
    public int MaxHealth { get => maxHealth; set => maxHealth = value; }
    public int Health { get => health; set => health = value; }
    public int MaxMana { get => maxMana; set => maxMana = value; }
    public int Mana { get => mana; set => mana = value; }
    public int MaxAmor { get => maxAmor; set => maxAmor = value; }
    public int Amor { get => amor; set => amor = value; }
    public bool IsDamaging { get => isDamaging; set => isDamaging = value; }
    public bool IsPoisoning { get => isPoisoning; set => isPoisoning = value; }
    public bool IsBurning { get => isBurning; set => isBurning = value; }

    // Movement
    public bool IsMoving { get => isMoving; set => isMoving = value; }

    // Dash
    public bool IsDashing { get => isDashing; set => isDashing = value; }

    // Amor Regen
    public bool IsRegeningAmor { get => isRegeningAmor; set => isRegeningAmor = value; }

    protected virtual void Update()
    {
        Time.timeScale = speed;
    }

    //===========================================Unity============================================
    public override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadComponent(ref this.rb, transform, "LoadRb()");
        this.LoadComponent(ref this.body, transform, "LoadBody()");
        this.LoadComponent(ref this.model, transform.Find("Model"), "LoadModel()");
    }
}
