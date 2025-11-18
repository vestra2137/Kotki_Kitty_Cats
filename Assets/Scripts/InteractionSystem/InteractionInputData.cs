using UnityEngine;

namespace VHS
{
    [CreateAssetMenu(fileName = "InteractionInputData", menuName = "InteractionSystem/InputData")]
    public class InteractionInputData : ScriptableObject
    {
        [Header("Internal")]
        public bool interactedClicked;
        public bool interactedRelease;

        public bool InteractedClicked
        {
            get => interactedClicked;
            set => interactedClicked = value;
        }

        public bool InteractedRelease
        {
            get => interactedRelease;
            set => interactedRelease = value;
        }

        public void Reset()
        {
            interactedClicked = false;
            interactedRelease = false;
        }
    }
}

