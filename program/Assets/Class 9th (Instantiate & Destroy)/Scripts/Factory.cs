using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public enum UnitType
{
    WRAITH,
    SLIME
}
public class Factory : MonoBehaviour
{
    public Wrairh wraith;
    public Slime slime;

    public void Create(UnitType unitType)
    {
        Unit unit = null;

        float x = Random.Range(0.0f, 5.0f);
        float z = Random.Range(0.0f, 5.0f);

        switch (unitType)
        {
            case UnitType.SLIME : unit = Instantiate(slime, new Vector3(x, 0, z), Quaternion.identity);
                break;
            case UnitType.WRAITH: unit = Instantiate(wraith, new Vector3(x, 0, z), Quaternion.identity);
                break;
        }

        unit.Move();
    }
}
