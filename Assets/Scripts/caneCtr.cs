using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class caneCtr : MonoBehaviour
{
    // Start is called before the first frame update
    private Vector3 VecDirec = Vector3.zero;
    public int count = 0;
    public float Speed;
    private Rigidbody RigPlayer;
    void Start()
    {
        RigPlayer = GetComponent<Rigidbody>();
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
        RigPlayer.AddForce(VecDirec);
    }

}
/*public class playerCtr : MonoBehaviour
{
    // Start is called before the first frame update
    private Vector3 VecDirec = Vector3.zero;
    public int count = 0;
    public float Speed;
    private Rigidbody RigPlayer;
    public Text countText;
    public Text winText;
    void Start()
    {
        RigPlayer = GetComponent<Rigidbody>();
        winText.text = "";
        setText();
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
        RigPlayer.AddForce(VecDirec);
    }
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("***********************");
        if (other.CompareTag("pickUp"))
        {
            other.gameObject.SetActive(false);
            Debug.Log("11111111");
            ++count;
            setText();
        }
    }
    void setText()
    {
        countText.text = "Count: " + count.ToString();
        if (count >= 4)
        {
            winText.text = "YOU WIN";
        }
    }*/
