﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CashInBox
{
    class GridConsultarMembro
    {
        public int Id { set; get; }
        public string Nome { set; get; }
        public string Cpf { set; get; }
        public string Numero { get; set; }
        public string Grupo { get; set; }
        public string Email { get; set; }
        public string Voluntario { get; set; }
        public string Biblioteca { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
    }
}
