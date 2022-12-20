using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckBehind : MonoBehaviour
{
    Vector3 moveVec;
    public float speed;
    public Transform target;
    public GameObject cam;
    void Update()
    {
        moveVec = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical"));

        transform.Translate(moveVec.normalized * Time.deltaTime * speed);

        cam.transform.position = transform.position + new Vector3(0f, 10f, 0f);
        CheckTragetPos();
    }

    public void CheckTragetPos()
    {
        Debug.Log(Vector3.Angle(-transform.forward ,target.position - transform.position));
        if (Vector3.Angle(-transform.forward, target.position - transform.position) < 45)
        {
            Debug.Log("Target이 Player 뒤에 있습니다");
        }
    }
}
