using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WSTower_Midnight.Models;

namespace WSTower_Midnight.Repository
{
    public class UsuarioRepository
    {
        readonly SQLiteAsyncConnection _Database;

        public UsuarioRepository(string dbPath)
        {
            _Database = new SQLiteAsyncConnection(dbPath);
            _Database.CreateTableAsync<Usuario>().Wait();
        }
        public Task<List<Usuario>> GetUsuarioAsync()
        {
            return _Database.Table<Usuario>().ToListAsync();
        }

        public Task<Usuario> Verificacao(string email, string senha)
        {
            return _Database.Table<Usuario>().FirstOrDefaultAsync(u => u.Email == email && u.Senha == senha);
        }

        public Task<int> SaveUsuarioAsync(Usuario usuario)
        {
            return _Database.InsertAsync(usuario);
        }
    }

    
}
