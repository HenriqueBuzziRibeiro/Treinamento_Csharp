﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_InterfaceExercicio
{
    public class SalvarXml : ArquivoBase, ISalvar
    {
        public void Salvar() 
        {
            Console.WriteLine("Salvar arquivo em Xml");
        }

        public override void Nome()
        {
            Console.WriteLine("Definir nome Xml");   
        }



    }
}
