using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.EventSystems;

using Photon.Pun;

using Photon.Pun.Demo.PunBasics;

namespace Com.MyCompany.MyGame
{
    public class Movement : MonoBehaviourPunCallbacks, IPunObservable
    {
        public float moveSpeed = 10f;
        public float rotSpeed = 50f;

        void IPunObservable.OnPhotonSerializeView(PhotonStream stream, PhotonMessageInfo info)
        {
            throw new System.NotImplementedException();
        }

        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            if (photonView.IsMine)
            {
                if (Input.GetKey(KeyCode.W))
                {
                    transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
                }
                if (Input.GetKey(KeyCode.S))
                {
                    transform.Translate(Vector3.back * moveSpeed * Time.deltaTime);
                }
                if (Input.GetKey(KeyCode.Q))
                {
                    transform.Translate(Vector3.up * moveSpeed * Time.deltaTime);
                }
                if (Input.GetKey(KeyCode.E))
                {
                    transform.Translate(Vector3.down * moveSpeed * Time.deltaTime);
                }
                if (Input.GetKey(KeyCode.A))
                {
                    transform.Translate(Vector3.left * moveSpeed * Time.deltaTime);
                }
                if (Input.GetKey(KeyCode.D))
                {
                    transform.Translate(Vector3.right * moveSpeed * Time.deltaTime);
                }
                if (Input.GetKey(KeyCode.LeftArrow))
                {
                    transform.Rotate(Vector3.down, rotSpeed * Time.deltaTime);
                }
                if (Input.GetKey(KeyCode.RightArrow))
                {
                    transform.Rotate(Vector3.up, rotSpeed * Time.deltaTime);
                }
            }
        }
    }
}
