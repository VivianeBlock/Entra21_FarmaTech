﻿using DAL.Model.Consultas;
using DAL.Model.Objetos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Model
{
    public class Login_DAL
    {
        private static HashLogin hash = new HashLogin(SHA512.Create());
        public static bool VerificaCredenciais(string login, string senha)
        {
            List<string> senhas = new List<string>();
            string select = $"SELECT * from dbo.Usuarios WHERE Login = '{login}'";
            SqlCommand cmd = new SqlCommand(select, DbConnection.conn);
            DbConnection.conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                UsuarioStatic.Nome = dr["Nome"].ToString();
                UsuarioStatic.Filial = dr["Filial"].ToString();
                UsuarioStatic.Contato = dr["Contato"].ToString();
                UsuarioStatic.NivelAcesso = Convert.ToInt32(dr["NivelAcesso"]); //Preenche as informacoes do usuario
                UsuarioStatic.NivelAcessoTemp = Convert.ToInt32(dr["NivelAcesso"]);
                senhas.Add(dr["Senha"].ToString());
            }
            dr.Close();
            DbConnection.conn.Close();



            foreach (var item in senhas)
            {
                if (hash.VerificarSenha(senha, item))
                {
                    return true;
                }
            }

            return false;
        }
        public static bool VerificaNivelAcesso(string login, string senha)
        {
            string select = $"SELECT * from dbo.Usuarios WHERE Login = '{login}' AND Senha = '{hash.CriptografarSenha(senha)}'";
            SqlCommand cmd = new SqlCommand(select, DbConnection.conn);
            DbConnection.conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {

                if (Convert.ToInt32(dr["NivelAcesso"]) > 1)
                {
                    dr.Close();
                    DbConnection.conn.Close();
                    return true;
                }
            }
            dr.Close();
            DbConnection.conn.Close();
            return false;
        }
    }
}
