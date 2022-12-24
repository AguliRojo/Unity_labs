using UnityEngine;

public class CameraPicker : MonoBehaviour
{
    public Camera firstPersonCamera;
    public Camera overheadCamera;

    public void ShowOverheadView() {
        firstPersonCamera.enabled = false;
        overheadCamera.enabled = true;
    }

    public void ShowFirstPersonView() {
        firstPersonCamera.enabled = true;
        overheadCamera.enabled = false;
    }

    void Start()
    {
        ShowOverheadView();
    }

    void Update()
    {
        if(overheadCamera)
        {
            if (Input.GetKeyDown(KeyCode.C)){
                ShowFirstPersonView();
            }
        }
        if(firstPersonCamera)
        {
            if (Input.GetKeyDown(KeyCode.C)){
                ShowOverheadView();
            }
        }
    }
}
