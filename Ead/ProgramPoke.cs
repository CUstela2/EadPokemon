namespace Ead{

public static class ProgramPoke
{
    public static void Rodar()
    {
        var charizard = new Pokemon("Charizard", 110.5, 1.7);
        charizard.Tipos.Add("Fogo");
        charizard.Tipos.Add("Voador");

        charizard.Ataques.Add(new Ataque("Explosão de Fogo", "Fogo"));
        charizard.Ataques.Add(new Ataque("FirePunch", "Meele"));
        charizard.Ataques.Add(new Ataque("Lança chama", "Fogo"));

        charizard.ExibirInformacoes();
    }
}
}
//  fiz pq queria chamar em uma linha só a program Main
