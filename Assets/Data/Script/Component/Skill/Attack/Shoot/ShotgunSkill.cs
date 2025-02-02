using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotgunSkill : ShootSkill
{
    //==========================================Variable==========================================
    [Header("SingleShot")]
    [SerializeField] protected int bulletCount;
    [SerializeField] protected float spreadAngle;

    //==========================================Get Set===========================================
    public int BulletCount { get => bulletCount; set => bulletCount = value; }
    public float SpreadAngle { get => spreadAngle; set => spreadAngle = value; }

    //==========================================Override==========================================
    protected override void UseSkill()
    {
        float halfAngle = this.spreadAngle / 2;
        List<Transform> bullets = new List<Transform>();
        Vector3 spawnPos = transform.position;

        for (int i = 0; i < this.bulletCount; i++)
        {
            float angleZ = (i * this.spreadAngle / this.bulletCount) - halfAngle;
            Quaternion spawnRot = Quaternion.Euler(0, 0, angleZ);
            Transform newBullet = BulletSpawner.Instance.SpawnByObj(this.bulletObj, spawnPos, spawnRot);

            if (newBullet == null) return;
            bullets.Add(newBullet);
        }

        foreach (Transform bullet in bullets) bullet.gameObject.SetActive(true);
    }
}
