using StarterAssets;
using UnityEditor;
    using UnityEngine;

    public class CubeInteraction : MonoBehaviour, IInteractable
    {
        public void Interact()
        {
            Debug.Log("tu recuperes la clef");
            HUDManager.Instance.ShowInteractionText("Clef swagg");
            FirstPersonController.ajoutListe("cucul");
            Destroy(this.gameObject);
        }
    }
