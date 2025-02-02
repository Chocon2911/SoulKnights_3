using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BurstSkill : ShootSkill
{
    //==========================================Variable==========================================
    [Header("Burst")]
    [SerializeField] protected int burstCount;
    [SerializeField] protected int tempBurstCount;
    [SerializeField] protected Cooldown burstCD;
    [SerializeField] protected bool isBurst;

    //==========================================Get Set===========================================
    public int BurstCount => burstCount;
    public int TempBurstCount => tempBurstCount;
    public Cooldown BurstCD { get => burstCD; set => burstCD = value; }

    //===========================================Unity============================================
    protected override void FixedUpdate()
    {
        base.FixedUpdate();
        this.RechargingBurst();
        this.Shooting();
        this.FinishingBurst();
    }

    //==========================================Override==========================================
    protected override void RechargingSkill()
    {
        if (this.isBurst) return;
        base.RechargingSkill();
    }

    protected override void UsingSkill()
    {
        if (this.isBurst) return;
        base.UsingSkill();
    }

    protected override void UseSkill()
    {
        this.isBurst = true;
    }

    //===========================================Burst============================================
    protected virtual void RechargingBurst()
    {
        if (!this.isBurst) return;
        if (this.burstCD.IsReady) return;
        this.RechargeBurst();
    }

    protected virtual void RechargeBurst()
    {
        this.burstCD.CoolingDown();
    }

    //===========================================Shoot============================================
    protected virtual void Shooting()
    {
        if (!this.isBurst) return;
        if (!this.burstCD.IsReady) return;
        this.Shoot();
    }

    protected virtual void Shoot()
    {
        Vector3 spawnPos = transform.position;
        Quaternion spawnRot = transform.rotation;
        Transform newBulletObj = BulletSpawner.Instance.SpawnByObj(this.bulletObj, spawnPos, spawnRot);

        if (newBulletObj == null) return;
        newBulletObj.gameObject.SetActive(true);
    }

    //========================================Finish Burst========================================
    protected virtual void FinishingBurst()
    {
        if (this.tempBurstCount < this.burstCount) return;
        this.FinishBurst();
    }

    protected virtual void FinishBurst()
    {
        this.tempBurstCount = 0;
        this.isBurst = true;
    }
}
