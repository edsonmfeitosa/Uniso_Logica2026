using UnityEngine;

public class somaNumeros : MonoBehaviour
{
    public float numero1;
    public float numero2;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //float numero1 = 10;
        //float numero2 = 20.5f;
        float resultado = numero1 + numero2;
        Debug.Log("O resultado da soma é: " + resultado);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0,1,0);
    }
}
