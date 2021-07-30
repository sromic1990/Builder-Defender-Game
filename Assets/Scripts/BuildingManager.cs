using Unity.Mathematics;
using UnityEngine;

public class BuildingManager : MonoBehaviour
{
    [SerializeField] private Transform pfWoodHarvestor;
    private Camera _camera;
    
    private void Start()
    {
        _camera = Camera.main;
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(pfWoodHarvestor, GetMousePosition(), Quaternion.identity);
        }
    }

    private Vector3 GetMousePosition()
    {
        Vector3 mouseWorldPosition = _camera.ScreenToWorldPoint(Input.mousePosition);
        mouseWorldPosition.z = 0f;
        return mouseWorldPosition;
    }
}
