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
        //Реализовать выборку из 1)Умножает кол-во войск 2) Умножает в отрицательную сторону. 3) Прибавляет 4) Уменьшает.
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
