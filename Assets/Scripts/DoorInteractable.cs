using StarterAssets;
using System.Collections.Generic;
using UnityEngine;

public class DoorInteractable : MonoBehaviour, IInteractable
{


    public List<GameObject> listOfDoors;
    public void Interact()
    {
        Debug.Log("tu ouvre la porte");
        if (FirstPersonController.listeDesItems.Count > 0)
        {
            HUDManager.Instance.ShowInteractionText("Ouverture de la porte");
            //GetComponent<Animator>().SetBool("isOpen_obj_1", true);
            foreach(var door in listOfDoors)
            {
                Destroy(door);
            }
        }
        else
        {
            HUDManager.Instance.ShowInteractionText("Il te manque la clef");
        }
    }

}
