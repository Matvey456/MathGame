using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SettingsMenu : MonoBehaviour
{
    [SerializeField] private GameObject mainMenuPanel, settingsMenuPanel;
    [SerializeField] private Slider diapazonSlider;
    [SerializeField] private TMP_Text diapazonText;
    [SerializeField] private Button backButton;

    private void Start()
    {
        StaticHolder.diapazonNumbers = StaticHolder.defaultDiapazonNumbers;
        diapazonSlider.maxValue = StaticHolder.defaultDiapazonNumbers;
        diapazonSlider.value = StaticHolder.defaultDiapazonNumbers;
       
        SliderText(diapazonSlider.value);
        diapazonSlider.onValueChanged.AddListener(SliderText);        
        backButton.onClick.AddListener(Back);
    }
    
     private void SliderText(float arg)
     {
         diapazonText.text = diapazonSlider.value.ToString();
         StaticHolder.diapazonNumbers--;
     }
    
    private void Back()
    {
        settingsMenuPanel.SetActive(false);
        mainMenuPanel.SetActive(true);
    }
}
