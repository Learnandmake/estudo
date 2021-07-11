﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace freitrabalho.database
{
    class databaseusuario
    {

        database.entity.freitrabalhoEntities banco = new database.entity.freitrabalhoEntities();

        public void inserir(database.entity.tbusuario usuario)
        {
            banco.tbusuario.Add(usuario);
            banco.SaveChanges();
        }
        public List<entity.tbusuario> btodos ()
        {
            List<entity.tbusuario> lista = banco.tbusuario.ToList();
            return lista;
        }
        public List<entity.tbusuario> flista(string nick)
        {
            List<entity.tbusuario> lista = banco.tbusuario.Where(t=>t.nick == nick ).ToList();
            return lista;
        }
        public void alterar(entity.tbusuario usuario)
        {
            entity.tbusuario lista = banco.tbusuario.FirstOrDefault(t => t.nick == usuario.nick);
            if (lista != null)
            {
                lista.email = usuario.email;
                lista.registro = usuario.registro;
                lista.nick = usuario.email;
            }
            banco.SaveChanges();

        }
    }
}
