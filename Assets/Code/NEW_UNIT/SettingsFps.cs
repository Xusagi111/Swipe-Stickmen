using UnityEngine;

namespace Assets.Code.NEW_UNIT
{
    public class SettingsFps : MonoBehaviour
    {
        [SerializeField] private int _valueFps;

        public void Update()
        {
            Application.targetFrameRate = _valueFps;
        }
    }
}