﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace freitrabalho2._0.bussines
{
    class bussinespontuacao
    {
        database.databasepontuacao data = new database.databasepontuacao();
        public void inserir(database.entity.tbpontuacao pontuacao)
        {
            data.inserir(pontuacao);

        }
        public List<database.entity.tbpontuacao> ltodos()
        {
            List<database.entity.tbpontuacao> lista = data.btodos();
            return lista;
        }
        public void alterar(database.entity.tbpontuacao usuario)
        {
            data.alterar(usuario);
        }
        public void deletar(database.entity.tbpontuacao pontuacao)
        {
            data.deletar(pontuacao);
        }
        public database.entity.tbpontuacao buscarpontuacaopnick(string nick)
        {
            database.entity.tbpontuacao lista = data.buscarpontuacaopnick(nick);
            return lista;
        }
        public void addpontuacao(string nick)
        {
            data.addpontuacao(nick);
        }
        public void reduzirpontuacao(string nick)
        {
            data.reduzirpontuacao(nick);
        }
    }
}
