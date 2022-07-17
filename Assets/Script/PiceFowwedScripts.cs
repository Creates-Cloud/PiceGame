using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PiceFowwedScripts : MonoBehaviour
{
    public const int Upwalk = 0;
    public const int RightWalk = 1;
    public const int DownWalk = 2;
    public const int LeftWalk = 3;
    public int state = 2;
    private float speed = 3;
    // Update is called once per frame
    void Update()
    {
        Inputkey();
        switch(state)
        {
            case Upwalk:
            {
               this.GetComponent<Animator>().SetInteger("walk", Upwalk);
               break;
            }
            case LeftWalk:
            {
                this.GetComponent<Animator>().SetInteger("walk",LeftWalk);
                break;
            }
             case RightWalk:
             {
               this.GetComponent<Animator>().SetInteger("walk",RightWalk);
                break;
             }
             case DownWalk:
             {
                this.GetComponent<Animator>().SetInteger("walk",DownWalk);
                break;
             }
                
        }
    }
    public void Inputkey() //操作キーはこちらへ　操作キーはWASDでお願いします
    { 
       if(Input.GetKey(KeyCode.W))
       {
        state = Upwalk;
        this.transform.Translate(0,speed*Time.deltaTime,0);
       }
    }
}
