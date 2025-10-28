using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Build;

    namespace VHS
{
[CreateAssetMenu(fileName = "InteractionInputData", menuName = "InteractionSystem/InputData")]
public class InteractionInputData : ScriptableObject

{
    public bool m_interactedClicked;

    public bool m_interactedRelase;

    public bool InteractedClicked
    {
        get => m_interactedClicked;
        set => m_interactedClicked = value;
    }

    public bool InteractedRelase
    {
        get => m_interactedRelase;
        set => m_interactedRelase = value;
    }

    public void Reset()
    {
        m_interactedClicked = false;
        m_interactedRelase = false;
    }
}
}
