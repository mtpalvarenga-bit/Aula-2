using UnityEngine;
using UnityEngine.InputSystem;

public class MovimentoJogador : MonoBehaviour
{
    public Rigidbody corpoJogador;

    void Start()
    {
        // Inicialização
    }

    void Update()
    {
        // Movimento para a frente
        corpoJogador.AddForce(0, 0, 6);

        // Movimento lateral mais rápido
        if (Keyboard.current.leftArrowKey.isPressed)
        {
            corpoJogador.AddForce(-7, 0, 0);
        }

        if (Keyboard.current.rightArrowKey.isPressed)
        {
            corpoJogador.AddForce(7, 0, 0);
        }
    }
}
