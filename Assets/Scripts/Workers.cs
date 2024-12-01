using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Workers : MonoBehaviour
{
    private bool isselected;
    public LayerMask resourceLayer;
    public float collectDistanse;
    Resourse currentResource;
    public float timeBetweencollect;
    float nextCollectTime;
    public int collectAmount;
    GameObject BloodAlter;
    public GameObject resourcepopup;
    public GameObject deathSound;
    public float alterDistance;

    // private Animator wAnim;//* not working

    // Start is called before the first frame update
    void Start()
    {   

    // wAnim = GetComponent<Animator>();//* not working

        BloodAlter =GameObject.FindGameObjectWithTag("Alter");
    }

    // Update is called once per frame
    void Update()
    {   //! Moving Worker
        if (isselected==true)
        {
            Vector3 mousePosition =Camera.main.ScreenToWorldPoint(Input.mousePosition) ;//the mouse position is in pixel value we have toconvert it into world poition
            mousePosition.z=0;
            transform.position=mousePosition;
        } else
        {
            //? Checking if the worker is near the alter to be scarifised
            if (Vector3.Distance(transform.position , BloodAlter.transform.position)<=alterDistance)
            {
                Instantiate(deathSound);
                ResourceManager.instance.AddWorkerSacrifised();
                Destroy(gameObject); // destroy worker if it is near alter 
            }
            //! checking nearby resource of a worker
            Collider2D col=Physics2D.OverlapCircle(transform.position,collectDistanse,resourceLayer);//it will create a invisible circle starting from worker & check if a resourse is in the circle
            if (col != null && currentResource == null)
            {
                currentResource=col.GetComponent<Resourse>();//assign the current resourse
            } else
            {
                currentResource=null;
            }
            //! Mining Resource
            if (currentResource != null)
            {
                // wAnim.SetBool("isCollecting",true);//* Not Working currently

                if (Time.time> nextCollectTime)// It is a time mechanism used to create a gap between each resouse collected
                {   
                    Instantiate(resourcepopup,transform.position,Quaternion.identity);
                    nextCollectTime=Time.time + timeBetweencollect;
                    currentResource.resourseAmount -= collectAmount;
                    ResourceManager.instance.AddResource(currentResource.resourseType, collectAmount);
                }
            }
            // else//*It's not working for some reason?????????????????????????
            // {
            //      wAnim.SetBool("isCollecting",false);
            // }
        }
    }
    private void OnMouseDown()//It get called automatically whenever left click the mouse
    {
        isselected=true;
    }
    private void OnMouseUp() {
        isselected=false;
    }
}
