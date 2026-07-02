public class InimigoIA
{
public float Velocidade { get; set; } = 2.0f;
public float PosicaoX { get; private set; } = 0.0f;
public int Vida { get; private set; } = 100;
public void Mover(float tempo)
{
PosicaoX += Velocidade * tempo;
Console.WriteLine($"Inimigo se moveu para a posição: {PosicaoX}");
}
public void VerificarSaude()
{
if (Vida <= 0)
{
Console.WriteLine("Inimigo derrotado!");
}
else
{
Console.WriteLine($"Inimigo ativo com {Vida} de vida.");
}
}
}