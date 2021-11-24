using UnityEngine;

public class Movement : MonoBehaviour
{
    public Transform[] goal;
    public float speed;
    public float stopDistance;
    public int goalNum;

    private void LateUpdate()
    {
        if(goalNum < goal.Length)
        {
            Vector3 dir = goal[goalNum].transform.position - transform.position;

            if (dir.magnitude > stopDistance)
            {
                transform.LookAt(new Vector3(dir.x, transform.position.y, dir.z));
                transform.Translate(dir.normalized * speed * Time.deltaTime, Space.World);
            }
            else
            {
                goalNum++;
            }
        }
    }
}