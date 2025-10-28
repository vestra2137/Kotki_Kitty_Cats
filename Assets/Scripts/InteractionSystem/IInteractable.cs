using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace VHS
{
    public interface IInteractable
    {
        float HoldDuration { get; }

        bool HoldInteract { get; }

        bool MultipleUse { get; }

        bool IsInteractable { get; }

        void OnInteract();
    }
}
