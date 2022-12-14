using System.Collections;
using System.Collections.Generic;
using Photon.Pun;
using UnityEngine;

public class PreparePool : MonoBehaviour
{
    public List<GameObject> Prefabs;
    private Photon PhotonNetwork;
    private Photon DefaultPool;

    // Start is called before the first frame update
    void Start()
    {
        DefaultPool pool = PhotonNetwork.PrefabPool as DefaultPool;
        if(pool != null && this.Prefabs != null){
            foreach(GameObject prefab in this.Prefabs){
                pool.ResourceCache.Add(prefab.name, prefab);
            }
        }
    }
}
