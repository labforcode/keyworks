﻿namespace TesteKeyworks.Cadastros.Dominios.ValueObjects.Responsaveis
{
    public class Responsavel
    {
        public Responsavel(string nome,
                           string email)
        {
            Nome = nome;
            Email = email;
        }

        public string Nome { get; private set; }

        public string Email { get; private set; }
    }
}
