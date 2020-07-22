using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace WSTower_Midnight.Models
{
    public class Evento
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public string Local { get; set; }
        public string Data { get; set; }
    }
}
