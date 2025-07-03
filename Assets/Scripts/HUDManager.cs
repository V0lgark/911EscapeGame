using UnityEngine;
using TMPro;

public class HUDManager : MonoBehaviour
{
    public static HUDManager Instance;

    public TMP_Text interactionText; 
    public float displayDuration = 2f;

    private float timer;

    void Awake()
    {
        if (Instance == null)
            Instance = this;
        else
            Destroy(gameObject);
    }

    public void ShowInteractionText(string text)
    {
        interactionText.text = text;
        interactionText.gameObject.SetActive(true);
        timer = displayDuration;
    }

    void Update()
    {
        if (interactionText.gameObject.activeSelf)
        {
            timer -= Time.deltaTime;
            if (timer <= 0)
            {
                interactionText.gameObject.SetActive(false);
            }
        }
    }
}
