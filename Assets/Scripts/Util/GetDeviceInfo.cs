using TMPro;
using UnityEngine;

namespace KrazyKrakenGames.DeviceInformation
{
    public enum DeviceType
    {
        DESKTOP = 0,
        MOBILE = 1
    }

    public class GetDeviceInfo : MonoBehaviour
    {
        public static GetDeviceInfo Instance = null;


        public float width;
        public float height;

        public TextMeshProUGUI labelText;

        [SerializeField] private DeviceType type;

        private void Awake()
        {
            if (Instance == null)
            {
                Instance = this;
            }
            else
            {
                Destroy(gameObject);
            }
        }

        private void Update()
        {
            GetScreenSize();

            DetermineDeviceType();
        }

        private void GetScreenSize()
        {
            width = Screen.width;
            height = Screen.height;

            labelText.text = $"Width:{width.ToString()} and Height:{height.ToString()}";

        }

        private void DetermineDeviceType()
        {
            if(width > height)
            {
                type = DeviceType.DESKTOP;
            }
            else
            {
                type = DeviceType.MOBILE;
            }
        }
    }
}
