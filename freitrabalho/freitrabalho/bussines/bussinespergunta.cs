﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace freitrabalho.bussines
{
    class bussinespergunta
    {
        database.databasepergunta data = new database.databasepergunta();
        public void inserir(database.entity.tbpergunta pergunta)
        {
            data.inserir(pergunta);
        }
    }
}
