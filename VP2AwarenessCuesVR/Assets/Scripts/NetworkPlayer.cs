
using MLAPI;
using MLAPI.Messaging;
using MLAPI.NetworkVariable;
using UnityEngine;


namespace Network
{
    public class NetworkPlayer : NetworkBehaviour
    {
        //[SerializeField] public NetworkObject VRPlayerPrefab;

        public Transform playerPrefab;
        public Transform observerPrefab;
        public GameObject player;
        public GameObject observer;

        //public GameObject observerView;
        public NetworkVariableVector3 Position = new NetworkVariableVector3(new NetworkVariableSettings
        {
            WritePermission = NetworkVariablePermission.ServerOnly,
            ReadPermission = NetworkVariablePermission.Everyone
        });
        
        public override void NetworkStart()
        {
            //Move();
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
            return new Vector3(Random.Range(1f, 5f), 1f, Random.Range(1f, 5f));
        }
        
        void Update()
        {
            transform.position = Position.Value;
        }
    }
}