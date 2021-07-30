using DefaultNamespace;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.Serialization;

public class BuildingManager : MonoBehaviour
{
    private BuildingTypeListSO _buildingTypeList;
    private BuildingTypeSO _buildingType;
    private Camera _camera;
    
    private void Start()
    {
        _camera = Camera.main;
        _buildingTypeList = Resources.Load<BuildingTypeListSO>(Constants.BUILDING_TYPE_LIST_PATH);
        _buildingType = _buildingTypeList.list[0];
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(_buildingType.prefab, GetMousePosition(), Quaternion.identity);
        }
        
        #region DEBUG
        if (Input.GetKeyDown(KeyCode.T))
        {
            _buildingType = _buildingTypeList.list[0];
        }
        if (Input.GetKeyDown(KeyCode.Y))
        {
            _buildingType = _buildingTypeList.list[1];
        }
        #endregion
    }

    private Vector3 GetMousePosition()
    {
        Vector3 mouseWorldPosition = _camera.ScreenToWorldPoint(Input.mousePosition);
        mouseWorldPosition.z = 0f;
        return mouseWorldPosition;
    }
}
