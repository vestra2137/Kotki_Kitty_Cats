using UnityEngine;

namespace VHS
{
    [System.Serializable]
    public class CameraInputData
    {
        public float InputVectorX;
        public float InputVectorY;

        public void ResetInput()
        {
            InputVectorX = 0f;
            InputVectorY = 0f;
        }
    }
}
