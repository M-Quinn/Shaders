using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetAnimation : MonoBehaviour
{
    public Animator Anim;
    public int SceneNumber;

    private void Start()
    {
        Anim.SetInteger("SceneNumber", SceneNumber);
    }
}
