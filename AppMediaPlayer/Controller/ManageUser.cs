using AppMediaPlayer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppMediaPlayer.Controller
{
    public class ManageUser
    {
        static int id = 0;
        static List<Usuario> usuarios = new List<Usuario>();
        public static List<Usuario> userLogged = new List<Usuario>();


        public void setUser(String user)
        {
            Usuario logged = new Usuario();
            logged.nome = user;
            userLogged.Add(logged);
        }

        public List<Usuario> GetLogged()
        {
            return userLogged;
        }

        public List<Usuario> GetUsuarios()
        {
            return usuarios;
        }

        public static bool criarUsuario(string name, string senha, string email)
        {
            try
            {
                Usuario novo_usuario = new Usuario();
                id++;
                novo_usuario.id = id;
                novo_usuario.nome = name;
                novo_usuario.email = email;
                novo_usuario.senha = senha;
                usuarios.Add(novo_usuario);
                Console.WriteLine(novo_usuario.id + " " + novo_usuario.nome);
                return true;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return false;
        }
    }
}
