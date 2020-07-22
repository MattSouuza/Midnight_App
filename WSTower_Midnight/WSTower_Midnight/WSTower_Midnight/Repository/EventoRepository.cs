using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WSTower_Midnight.Models;

namespace WSTower_Midnight.Repository
{
    public class EventoRepository
    {
        readonly SQLiteAsyncConnection _Database;

        public EventoRepository(string dbPath)
        {
            _Database = new SQLiteAsyncConnection(dbPath);
            _Database.CreateTableAsync<Evento>().Wait();
        }
        public Task<List<Evento>> GetEventoAsync()
        {
            return _Database.Table<Evento>().ToListAsync();
        }

        public Task<int> SaveEventoAsync(Evento evento)
        {
            return _Database.InsertAsync(evento);
        }
    }
}
