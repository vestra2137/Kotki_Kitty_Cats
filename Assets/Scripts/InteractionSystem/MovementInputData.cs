using UnityEngine;

namespace VHS
{
    [System.Serializable]
    public class MovementInputData
    {
        public Vector2 InputVector;
        public bool Jumped;

        public void ResetInput()
        {
            InputVector = Vector2.zero;
            Jumped = false;
        }
    }
}

