﻿using UnityEngine;
using Lean.Pool;
namespace SgUnity
{
    class Ptc : MonoBehaviour
    {
        void OnParticleSystemStopped() => LeanPool.Despawn(gameObject);
    }

}
