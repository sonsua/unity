using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoroutineCache : MonoBehaviour
{
    class compare : IEqualityComparer<float>
    {
        public bool Equals(float x, float y)
        {
            return x == y;
        }
        public int GetHashCode(float obj)
        {
            return (int)obj.GetHashCode();
        }
    }

    private static readonly Dictionary<float, WaitForSeconds> dictionary = 
        new Dictionary<float, WaitForSeconds>();

    public static WaitForSeconds waitForSeconds(float time)
    {
        WaitForSeconds waitForSeconds = null;

        if(dictionary.TryGetValue(time, out waitForSeconds)== false) {
        dictionary.Add(time, waitForSeconds= new WaitForSeconds(time));
        }
        return waitForSeconds;
    }
}
