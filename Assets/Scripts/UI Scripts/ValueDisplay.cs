using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace TowerDefence
{
    [RequireComponent(typeof(Text))]
    public class ValueDisplay : MonoBehaviour
    {
        public static UnityEvent<string, object> OnValueChange = new UnityEvent<string, object>();

        [SerializeField] private string valueName = "";
        private Text displayText;

        private void Awake()
        {
            displayText = GetComponent<Text>();
            OnValueChange.AddListener(ValueChanged);
        }

        void ValueChanged(string valueName, object value)
        {
            if(this.valueName == valueName)
            {
                displayText.text = value.ToString();
            }
        }
    }
}
