using UnityEngine;

public class Item : MonoBehaviour
{
    [SerializeField] protected int Change;
    void Start()
    {
        
    }
    void Update()
    {
        
    }

    public virtual void ItemAction()
    {
        Debug.Log("ITEEEM");
    }
}
