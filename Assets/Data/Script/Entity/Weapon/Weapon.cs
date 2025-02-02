using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : HuyMonoBehaviour
{
    //==========================================Variable==========================================
    [Header("Weapon")]
    [SerializeField] private WeaponSkillState firstSkillState;
    [SerializeField] private WeaponSkillState secondSkillState;

    //==========================================Get Set===========================================
    public WeaponSkillState FirstSkillState { get => firstSkillState; set => firstSkillState = value; }
    public WeaponSkillState SecondSkillState { get => secondSkillState; set => secondSkillState = value; }
}
