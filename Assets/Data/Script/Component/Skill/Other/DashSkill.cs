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
        this.FinishingDash();
    }

    //==========================================Override==========================================
    protected override void RechargingSkill()
    {
        if (this.isDashing) return;
        base.RechargingSkill();
    }

    protected override void UsingSkill()
    {
        if (!this.canDash) return;
        base.UsingSkill();
    }

    protected override void UseSkill()
    {
        this.isDashing = true;
    }

    //==========================================On Dash===========================================
    protected virtual void Dashing()
    {
        if (!this.isDashing) return;
        this.Dash();
    }

    protected virtual void Dash()
    {
        this.dashCD.CoolingDown();
        this.rb.velocity = this.dashSpeed * this.dashDir;
    }

    //========================================Finish Dash=========================================
    protected virtual void FinishingDash()
    {
        if (!this.dashCD.IsReady) return;
        this.FinishingDash();
    }

    protected virtual void FinishDash()
    {
        this.FinishSkill();
        this.isDashing = false;
        this.dashCD.ResetStatus();
        this.dashDir = Vector2.zero;
    }
}
