using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResponsiveSelector : MonoBehaviour,ISelector
{
    [SerializeField] private List<Transform> selectables;
    [SerializeField] private float threshold = 0.97f;
 
    private Transform _selection;
    public void Check(Ray ray)
    {
        _selection = null;

        var closest = 0f;

        for (int i =0; i<selectables.Count; i++) {
            var vect1 = ray.direction;
            var vect2 = selectables[i].position-ray.origin;

            var lookPercentage = Vector3.Dot(vect1.normalized, vect2.normalized);

            if (lookPercentage > threshold && lookPercentage > closest)
            {
                closest = lookPercentage;
                _selection = selectables[i].transform;
               
            }
        }
    }

    public Transform GetSelection()
    {
        return _selection;
    }

   
}
