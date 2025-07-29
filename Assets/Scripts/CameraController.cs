using UnityEngine;

public class CameraController : MonoBehaviour
{
    private bool doMovement = true;
    public float panSpeed = 30f;
    public float panBorderThickness = Screen.height / 20f;
    public float scrollSpeed = 5f;

    [Header("Camera Limits")]
    public float minY = 10f;
    public float maxY = 80f;
    public float minX = 0f;
    public float maxX = 70f;
    public float minZ = -10f;
    public float maxZ = 70f;

    void Update()
    {
        if (GameManager.gameIsOver)
        {
            this.enabled = false; // Disable camera movement when the game is over
            return;
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            doMovement = !doMovement;
            // Testing what this does
            Cursor.lockState = doMovement ? CursorLockMode.Locked : CursorLockMode.None;
            Cursor.visible = !doMovement;
        }

        if (!doMovement)
            return;

        if ((Input.GetKey(KeyCode.W) || Input.mousePosition.y >= Screen.height - panBorderThickness) &&
            transform.position.z < maxZ)
        {
            transform.Translate(Vector3.forward * panSpeed * Time.deltaTime, Space.World);
        }
        if ((Input.GetKey(KeyCode.S) || Input.mousePosition.y <= panBorderThickness) &&
            transform.position.z > minZ)
        {
            transform.Translate(Vector3.back * panSpeed * Time.deltaTime, Space.World);
        }
        if ((Input.GetKey(KeyCode.D) || Input.mousePosition.x >= Screen.width - panBorderThickness) &&
            transform.position.x < maxX)
        {
            transform.Translate(Vector3.right * panSpeed * Time.deltaTime, Space.World);
        }
        if ((Input.GetKey(KeyCode.A) || Input.mousePosition.x <= panBorderThickness) &&
            transform.position.x > minX)
        {
            transform.Translate(Vector3.left * panSpeed * Time.deltaTime, Space.World);
        }

        float scroll = Input.GetAxis("Mouse ScrollWheel");

        if (scroll != 0f)
        {
            Vector3 pos = transform.position;
            pos.y -= scroll * 1000f * scrollSpeed * Time.deltaTime;
            pos.y = Mathf.Clamp(pos.y, minY, maxY);
            transform.position = pos;
        }
    }
}
