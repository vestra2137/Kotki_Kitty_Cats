using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Collections.Generic;
using System.Collections;

namespace VHS
{
    public class InteractionUI : MonoBehaviour
    {
        [SerializeField] private Image progressBar;
        [SerializeField] private TextMeshProUGUI tooltipText;

        public void SetTooltip(string tooltip)
        {
            tooltipText.SetText(tooltip);
        }

        public void UpdateProgressBar(float fillAmount)
        {
            progressBar.fillAmount = fillAmount;
        }

        public void ResetUI()
        {
            progressBar.fillAmount = 0f;
            tooltipText.SetText("");
        }
    }
}
