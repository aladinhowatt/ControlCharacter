using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    public delegate void OnClickSurface(Vector3 point);

    public static event OnClickSurface onClickSurface;


    void Start()
    {
        
    }

    void Update()
    {
        if (GameManager.Instance.State != GameManager.GameState.Main) return;

        if(Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hitInfo;
            if(Physics.Raycast(ray,out hitInfo))
            {
                onClickSurface?.Invoke(hitInfo.point);
            }

        }
    }
}
