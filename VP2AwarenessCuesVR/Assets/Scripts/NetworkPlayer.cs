
using MLAPI;
using MLAPI.Messaging;
using MLAPI.NetworkVariable;
using UnityEngine;


namespace Network
{
    public class NetworkPlayer : NetworkBehaviour
    {
        //[SerializeField] public NetworkObject VRPlayerPrefab;

        public GameObject observerView;
        public NetworkVariableVector3 Position = new NetworkVariableVector3(new NetworkVariableSettings
        {
            WritePermission = NetworkVariablePermission.ServerOnly,
            ReadPermission = NetworkVariablePermission.Everyone
        });
        
        public override void NetworkStart()
        {
            InitializePlayer();

            Move();
        }

        public void InitializePlayer() 
        {
            if (NetworkManager.Singleton.IsHost) {
                Debug.Log("is Host and server");
                Debug.Log("PlayerObject: " + NetworkManager.Singleton.ConnectedClients[NetworkManager.Singleton.LocalClientId].PlayerObject);
                observerView = GameObject.Find("Observer");
                observerView.SetActive(false);
                //Destroy(NetworkManager.Singleton.ConnectedClients[NetworkManager.Singleton.LocalClientId].PlayerObject);
                //netObject = GameObject.Find("Observer");
                //NetworkObject netObject = GetComponent<NetworkObject>();
                //netobject.NetworkHide();

                //GameObject go = Instantiate(Observer, Vector3.zero, Quaternion.identity);
                //go.GetComponent<NetworkObject>().Spawn();
                /**
                NetworkObject NewVRPlayer = Instantiate(VRPlayerPrefab, Vector3.zero, Quaternion.identity);
                NewVRPlayer.SpawnAsPlayerObject(NetworkManager.Singleton.LocalClientId, null, false);
                Debug.Log("PlayerObject: " + NetworkManager.Singleton.ConnectedClients[NetworkManager.Singleton.LocalClientId].PlayerObject);
                */
            } 
            else 
            {
                Debug.Log("is Client");
                Debug.Log(NetworkManager.Singleton.ConnectedClients[NetworkManager.Singleton.LocalClientId].PlayerObject);
                //observerPlayer = GameObject.Find("Observer");
                //observerPlayer.SetActive(true);



                //clientPlayerObject = NetworkManager.Singleton.ConnectedClients[NetworkManager.Singleton.LocalClientId].PlayerObject;
                //Destroy(NetworkManager.Singleton.ConnectedClients[NetworkManager.Singleton.LocalClientId].PlayerObject);
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
            return new Vector3(Random.Range(1f, 5f), 1f, Random.Range(1f, 5f));
        }
        
        void Update()
        {
            transform.position = Position.Value;
        }
    }
}