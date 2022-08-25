using UnityEngine;

public class AddObstacles : MonoBehaviour
{
    [SerializeField] private AddUnit _addUnit;
    private void Start()
    {
        Create();
    }

    private void Create()
    {
       _addUnit = new AddUnit();
    }


    [System.Serializable]
    public class AddUnit
    {
        //����������� ������� �� 1)�������� ���-�� ����� 2) �������� � ������������� �������. 3) ���������� 4) ���������.
        public bool isFactor;
        [Range(2, 5)]
        public float Factor;
        public int CountUnit;

        public AddUnit()
        {
            Random.Range(0,1);
        }
    }
}
