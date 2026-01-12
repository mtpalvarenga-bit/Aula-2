using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class contarpontos : MonoBehaviour
{
  public Transform jogador;
  public TMP_Text contar;
    void Update()
    {
        contar.text = "Pontos: " + jogador.position.z.ToString("0");
    }
}
