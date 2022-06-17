﻿using TesteKeyworks.Cadastros.Dominios.Core.Comandos;

namespace TesteKeyworks.Cadastros.Dominios.Comandos.Materiais
{
    public abstract class ComandoMaterial : Comando
    {
        public int Codigo { get; protected set; }

        public string Descricao { get; protected set; }
    }
}