using System;

public partial class Usuario
{
    public bool Autenticar()
    {
        return ((Nome == "Rondinele") & (Senha == "senha"));
    }
}


