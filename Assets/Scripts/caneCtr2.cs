using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class caneCtr2 : MonoBehaviour
{
        // Start is called before the first frame update
        private Vector3 VecDirec = Vector3.zero;
        public int count = 0;
        public float Speed;
        public GameObject RigPlayer;
        void Start()
        {
            //RigPlayer = //GetComponent<Rigidbody>();
        }

        // Update is called once per frame
        void Update()
        {

        }
        private void FixedUpdate()
        {
            float moveHorizontal = Input.GetAxis("Horizontal");
            float moveVertical = Input.GetAxis("Vertical");
            VecDirec.x = moveHorizontal;
            VecDirec.z = moveVertical;
        RigPlayer.transform.position += VecDirec;//MovePosition(RigPlayer.transform.position + VecDirec);
            //RigPlayer.AddForce(VecDirec);
        }
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("***********************");
        if (other.CompareTag("ashcan"))
        {
            //other.gameObject.SetActive(false);
            Debug.Log("11111111");
            
           
        }
    }

}
