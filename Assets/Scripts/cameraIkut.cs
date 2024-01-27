using UnityEngine;

public class cameraIkut : MonoBehaviour
{
    public Transform camera, player;
    public Vector3 offset;

    private void Update()
    {
        camera.position = player.position + offset;
    }

}
