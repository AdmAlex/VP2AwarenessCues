
using MLAPI;
using MLAPI.Messaging;
using MLAPI.NetworkVariable;
using UnityEngine;

namespace Network
{
    public class NetworkPlayer : NetworkBehaviour
    {

        public GameObject observerPlayer;
        public NetworkVariableVector3 Position = new NetworkVariableVector3(new NetworkVariableSettings
        {
            WritePermission = NetworkVariablePermission.ServerOnly,
            ReadPermission = NetworkVariablePermission.Everyone
        });
        
        public override void NetworkStart()
        {
            InitiatePlayer();
        }

        public void InitiatePlayer() 
        {
            if (NetworkManager.Singleton.IsHost) {
                Debug.Log("is Host and server");
                
                observerPlayer = GameObject.Find("Observer");
                observerPlayer.SetActive(false);
            } 
            else 
            {
                Debug.Log("is Client");
                observerPlayer = GameObject.Find("Observer");
                observerPlayer.SetActive(false);
            }
        }
        
        public void Move()
        {
            if (NetworkManager.Singleton.IsServer)
            {
                var randomPosition = GetRandomPositionOnPlane();
                transform.position = randomPosition;
                Position.Value = randomPosition;
            }
            else
            {
                SubmitPositionRequestServerRpc();
            }
        }

        [ServerRpc]
        void SubmitPositionRequestServerRpc(ServerRpcParams rpcParams = default)
        {
            Position.Value = GetRandomPositionOnPlane();
        }

        static Vector3 GetRandomPositionOnPlane()
        {
            return new Vector3(Random.Range(1f, 3f), 1f, Random.Range(1f, 3f));
        }
        
        void Update()
        {
            transform.position = Position.Value;
        }
    }
}