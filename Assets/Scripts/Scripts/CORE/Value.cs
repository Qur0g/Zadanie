using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Dynamic representation of the Value in Game
/// </summary>
[System.Serializable]
public class Value
{
    private int _value;

    //Open Eq Screen here.
    public delegate void ValueUpdate(int value);
    public event ValueUpdate OnUpdate;

    public Value(int value)
    {
        Debug.Log("Create Value");
        _value = value;
    }

    public int value
    {
        get
        {
            return _value;
        }
        set
        {
            if (_value != value)
            {
                _value = value;

                if (OnUpdate != null)
                {
                    Debug.Log("Updated");
                    OnUpdate(value);
                }
            }
        }
    }

    public static Value operator +(Value a, int b)
    {
        a.value += b;
        return a;
    }

    public static Value operator -(Value a, int b)
    {
        a.value -= b;
        return a;
    }

    public override string ToString()
    {
        return value.ToString();
    }
}