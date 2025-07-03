using UnityEngine;

public class Interactor : MonoBehaviour
{
    public Transform InteractorSource;
    public float InteractRange;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Récupère la position et la direction de la caméra principale
        Vector3 cameraPos = Camera.main.transform.position;
        Vector3 cameraForward = Camera.main.transform.forward;

        // Crée le rayon depuis la caméra dans la direction où elle regarde
        Ray r = new Ray(cameraPos, cameraForward);

        // Affiche le rayon dans la scène
        Debug.DrawRay(r.origin, r.direction * InteractRange, Color.red);

        if (Input.GetKeyDown(KeyCode.E))
        {
            if (Physics.Raycast(r, out RaycastHit hitInfo, InteractRange))
            {
                if (hitInfo.collider.gameObject.TryGetComponent(out IInteractable interactObj))
                {
                    interactObj.Interact();
                }
            }
        }

    }
}

public interface IInteractable
{
    public void Interact();
}