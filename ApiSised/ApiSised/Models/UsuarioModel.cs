using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ApiSised.Models
{
    public class UsuarioModel
    {
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        private string nome;

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        private string usuario;

        public string Usuario
        {
            get { return usuario; }
            set { usuario = value; }
        }
        private string senha;

        public string Senha
        {
            get { return senha; }
            set { senha = value; }
        }
        private int perfil;

        public int Perfil
        {
            get { return perfil; }
            set { perfil = value; }
        }
        private bool autenticado;

        public bool Autenticado
        {
            get { return autenticado; }
            set { autenticado = value; }
        }
        private string msg;

        public string Msg
        {
            get { return msg; }
            set { msg = value; }
        }
    }
}