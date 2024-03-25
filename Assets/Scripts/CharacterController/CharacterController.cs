using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class CharacterController : MonoBehaviour
{
    //[SerializeField] protected CharacterAnimator characterAnimator = null;
    protected abstract void Move();
    protected abstract void Attack();
    protected abstract void TakeDamaged();

}
