using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Class to initialize prefab instances of frequently used GameObjects
 * take them back, and assign them again when needed.
 */
public class PrefabPool : MonoBehaviour {

    [SerializeField]
    GameObject prefab;
    List<GameObject> _activeObjects;
    //Objects in play
    List<GameObject> ActiveObjects
    {
        get
        {
            if(_activeObjects == null)
            {
                _activeObjects = new List<GameObject>();
            }
            return _activeObjects;
        }
    }

    List<GameObject> _availableObjects;
    //inactive objects that can be issued
    List<GameObject> AvailableObjects
    {
        get
        {
            if(_availableObjects == null)
            {
                _availableObjects = new List<GameObject>();
            }
            return _availableObjects;
        }
    }

    public GameObject GetObject()
    {
        GameObject obj;
        if (AvailableObjects.Count > 0)
        {
            obj = AvailableObjects[0];
            AvailableObjects.RemoveAt(0);
            try
            {
                obj.SetActive(true);
            }
            catch (MissingReferenceException e)
            {
                Debug.LogError("MRE from " + gameObject.name);
                throw e;
            }
        }
        else
        {
            //None available, so create a new one
            obj = Instantiate(prefab);
        }
        //Prep the object for the game world before returning
        obj.transform.parent = null;
        obj.transform.position = Vector3.zero;
        obj.transform.rotation = Quaternion.identity;
        obj.transform.localScale = Vector3.one;
        ActiveObjects.Add(obj);
        return obj;
    }

    public void ReturnObject(GameObject obj)
    {
        obj.SetActive(false);
        ActiveObjects.Remove(obj);
        AvailableObjects.Add(obj);
    }
}
