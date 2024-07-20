using UnityEngine;


namespace KrazyKrakenGames.DeviceInformation
{
    [DefaultExecutionOrder(1)]
    public class DeviceListener : MonoBehaviour
    {
        [SerializeField] private RectTransform content;

        [SerializeField] private GetDeviceInfo deviceInfo;

        [SerializeField] private float maxWidth;

        private void Start()
        {
            content = GetComponent<RectTransform>();

            deviceInfo = GetDeviceInfo.Instance;

        }

        private void Update()
        {
            if (deviceInfo != null)
            {
                float width = deviceInfo.width;
                if (deviceInfo.width > deviceInfo.height)
                {
                    width = maxWidth;
                }
                else
                {
                    width = deviceInfo.width;
                }

                content.sizeDelta = new Vector2(width, content.sizeDelta.y);
            }
        }
    }
}
