class InimigoIA
{
  public float Velocidade { get; set; } = 2.0f;
  public float PosicaoX { get; private set; } = 0.0f;

public void Mover(float tempo)
  {
PosicaoX += Velocidade * tempo;
Console.WriteLine($"Inimigo se moveu para a posição: {PosicaoX}");
  }
}