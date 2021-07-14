﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace freitrabalho.database
{
    class databasepontuacao
    {
        database.entity.freitrabalhoEntities1 banco = new database.entity.freitrabalhoEntities1();

        public void inserir(database.entity.tbpontuacao pontuacao)
        {
            banco.tbpontuacao.Add(pontuacao);
            banco.SaveChanges();
        }
        public List<entity.tbpontuacao> btodos()
        {
            List<entity.tbpontuacao> lista = banco.tbpontuacao.ToList();
            return lista;
        }
       
        public List<entity.tbpontuacao> flista(string nick)
        {
            List<entity.tbpontuacao> lista = banco.tbpontuacao.Where(t => t.nick == nick).ToList();
            return lista;
        }
        public entity.tbpontuacao buscarpontuacaopnick(string nick)
        {
            entity.tbpontuacao lista = banco.tbpontuacao.FirstOrDefault(t =>t.nick == nick) ;
            return lista;
        }
        public void deletar(entity.tbpontuacao pontuacao)
        {
            entity.tbpontuacao lista = banco.tbpontuacao.FirstOrDefault(t => t.idusuario == pontuacao.idusuario);
            banco.Entry(lista).State = System.Data.EntityState.Deleted;
            banco.SaveChanges();
        }
        public void alterar(entity.tbpontuacao usuario)
        {
            entity.tbpontuacao lista = banco.tbpontuacao.FirstOrDefault(t => t.idusuario == usuario.idusuario);
            if (lista != null)
            {
                lista.idusuario = usuario.idusuario;
                lista.nick = usuario.nick;
              
            }
            banco.SaveChanges();

        }
    }
}
