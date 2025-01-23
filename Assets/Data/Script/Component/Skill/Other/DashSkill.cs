using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DashSkill : Skill
{
    //==========================================Variable==========================================
    [Header("Dash")]
    [SerializeField] protected Rigidbody2D rb;
    [SerializeField] protected Cooldown dashCD;
    [SerializeField] protected float dashSpeed;
    [SerializeField] protected Vector2 dashDir;
    [SerializeField] protected bool canDash;
    [SerializeField] protected bool isDashing;

    //==========================================Get Set===========================================
    public Rigidbody2D Rb { get => rb; set => rb = value; }
    public Cooldown DashCD { get => dashCD; set => dashCD = value; }
    public float DashSpeed { get => dashSpeed; set => dashSpeed = value; }
    public Vector2 DashDir { get => dashDir; set => dashDir = value; }
    public bool CanDash { get => canDash; set => canDash = value; }
    public bool IsDashing { get => isDashing; set => isDashing = value; }

    //===========================================Unity============================================
    protected override void FixedUpdate()
    {
        base.FixedUpdate();
        this.Dashing();
    }

    protected virtual void Update()
    {
        this.Dash();
    }

    //===========================================Method===========================================
    protected virtual void Dash()
    {
        if (this.canDash && !this.isDashing && this.skillCD.IsReady) this.ActivateDash();
    }

    protected virtual void ActivateDash()
    {
        this.isDashing = true;
    }

    protected virtual void Dashing()
    {
        if (this.isDashing) this.DoDash();
    }

    protected virtual void DoDash()
    {
        this.dashCD.CoolingDown();
        this.rb.velocity = this.dashSpeed * this.dashDir;
    }
}
