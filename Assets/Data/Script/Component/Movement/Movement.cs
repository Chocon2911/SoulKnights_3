using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : HuyMonoBehaviour
{
    //==========================================Variable==========================================
    [Header("Movement")]
    [SerializeField] protected Rigidbody2D rb;
    [SerializeField] protected float moveSpeed;
    [SerializeField] protected Vector2 moveDir;
    [SerializeField] protected bool canMove;

    //==========================================Get Set===========================================
    public Rigidbody2D Rb { get => rb; set => rb = value; }
    public float MoveSpeed { get => moveSpeed; set => moveSpeed = value; }
    public Vector2 MoveDir { get => moveDir; set => moveDir = value; }
    public bool CanMove { get => canMove; set => canMove = value; }

    //===========================================Unity============================================
    protected virtual void Update()
    {
        this.Move();
    }

    //===========================================Method===========================================
    protected virtual void Move()
    {
        if (this.canMove) this.DoMove();
    }

    protected virtual void DoMove()
    {
        this.rb.velocity = this.moveSpeed * this.moveDir;
    }
}
