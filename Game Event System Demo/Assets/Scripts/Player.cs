using UnityEngine;

public class Player : MonoBehaviour
{
    public float moveDistance = 0.2f;


    #region Movement
    public void MoveUp()
    {
        Vector3 newPos = new Vector3(transform.position.x, transform.position.y + moveDistance, transform.position.z);
        transform.position = newPos;
    }
    public void MoveDown()
    {
        Vector3 newPos = new Vector3(transform.position.x, transform.position.y - moveDistance, transform.position.z);
        transform.position = newPos;
    }
    public void MoveLeft()
    {
        Vector3 newPos = new Vector3(transform.position.x - moveDistance, transform.position.y, transform.position.z);
        transform.position = newPos;
    }
    public void MoveRight()
    {
        Vector3 newPos = new Vector3(transform.position.x + moveDistance, transform.position.y, transform.position.z);
        transform.position = newPos;
    }
    #endregion

}
