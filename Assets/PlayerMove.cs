using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    //private float rotateSpeed = 30f;
    private float movespeed = 5;

    void LateUpdate()
    {
        //第一种控制移动
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        //朝一个方向移动 new Vector3(0, 0, v) * speed * Time.deltaTime是个向量
        transform.Translate(new Vector3(0, 0, v) * movespeed * Time.deltaTime);  //前后移动

        transform.Translate(new Vector3(h, 0, 0) * movespeed * Time.deltaTime); //左右旋转

        //        //第二种方式控制移动
        //        if (Input.GetKey(KeyCode.W)) //前进
        //        {
        //            transform.Translate(Vector3.forward * movespeed * Time.deltaTime);
        //        }
        //        if (Input.GetKey(KeyCode.S)) //后退
        //        {
        //            transform.Translate(Vector3.back * movespeed * Time.deltaTime);
        //        }
        //        if (Input.GetKey(KeyCode.A))//向左旋转
        //        {
        //            transform.Rotate(0, -rotateSpeed * Time.deltaTime, 0);
        //        }
        //        if (Input.GetKey(KeyCode.D))//向右旋转
        //　　{
        //            transform.Rotate(0, rotateSpeed * Time.deltaTime, 0);
        //        }
    }
}