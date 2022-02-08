using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlaneRaycaster : MonoBehaviour
{
    [SerializeField]
    NavMeshAgent player;

    private new Camera camera;

    // Start is called before the first frame update
    void Start()
    {
        camera = GetComponent<Camera>();
        if(MenuController.load)
        {
            Vector3 playerPos = LoadSaveManager.Instance.Load();
            player.Warp(playerPos);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            var ray = camera.ScreenPointToRay(Input.mousePosition);

            if(Physics.Raycast(ray, out RaycastHit hit, float.MaxValue))
            {
                if(hit.collider.name == "Plane") {
                    player.SetDestination(hit.point);
                }
            }
        }


    }

    public void SavePlayerPosition()
    {
        LoadSaveManager.Instance.Save(player.transform.position);
    }
}
