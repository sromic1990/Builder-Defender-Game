using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

[CreateAssetMenu(menuName = "SOs/BuildingTypeList")]
public class BuildingTypeListSO : ScriptableObject
{ 
    public List<BuildingTypeSO> list;
}
