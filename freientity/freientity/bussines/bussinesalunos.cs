﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace freientity.bussines
{
    class bussinesalunos
    {
        database.databasealuno data = new database.databasealuno();
        public void inserir (database.entity.tbaluno aluno)
        {
            data.inserirthpk(aluno);
        }
        public List<database.entity.tbaluno> listartda()
        {
            List<database.entity.tbaluno> lista = data.ltodosalfa();
            return lista;
        }
    }
}
