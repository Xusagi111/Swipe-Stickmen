using UnityEngine;

namespace Assets.Code
{
    public class SpawnObstacle : MonoBehaviour
    {
        [SerializeField] private Vector3 GizmosRadius;
        [SerializeField] private Transform _startPoint;
        [SerializeField] private Transform _endPoint;

        [SerializeField] private GameObject _prefabObstacles1;
        [SerializeField] private GameObject _prefabObstacles2;

        [SerializeField] private Transform ParentSpawnGameObj;

        [SerializeField] private int _countPointObstacles = 200;
        private Transform[] _pointToObstacles;


        private Transform _localTransform;
        private int _localRandomPoint;
        void OnDrawGizmos()
        {
            //Gizmos.color = Color.yellow;
            //Gizmos.DrawCube(_startPoint.position, GizmosRadius);
            //Gizmos.DrawCube(_endPoint.position, GizmosRadius);
        }

        private void Start()
        {
            CreatePoint();
            CreateObstacles();
        }

        private void CreateObstacles()
        {
            for (int i = 0; i < 100; i++)
            {
                _localRandomPoint = Random.Range(0, 1);
                _localTransform =  _pointToObstacles[Random.Range(0, _countPointObstacles - 1)];

                if (_localRandomPoint == 0)
                    Instantiate(_prefabObstacles1, _localTransform.position, Quaternion.identity, ParentSpawnGameObj);
                else
                    Instantiate(_prefabObstacles2, _localTransform.position, Quaternion.identity, ParentSpawnGameObj);
            }
        }

        private void CreatePoint()
        {
            _pointToObstacles = new Transform[_countPointObstacles];
            for (int i = 0; i < _pointToObstacles.Length; i++)
            {
                float z = Random.Range(_startPoint.position.z, _endPoint.position.z);
                float x = Random.Range(_startPoint.position.x + GizmosRadius.x / 2, _startPoint.position.x - GizmosRadius.x / 2);
                GameObject CurrentPoint = new GameObject();
                CurrentPoint.transform.position = new Vector3(x, 0, z);
                _pointToObstacles[i] = CurrentPoint.transform;
            }
        }
    }
}