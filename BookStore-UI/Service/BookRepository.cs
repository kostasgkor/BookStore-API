using Blazored.LocalStorage;
using BookStore_UI.Contracts;
using BookStore_UI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace BookStore_UI.Service
{
    public class BookRepository : BaseRepository<Book>, IBookRepository
    {
        private readonly IHttpClientFactory _client;
        private readonly ILocalStorageService _localstorage;

        public BookRepository(IHttpClientFactory client, ILocalStorageService localstorage) : base(client, localstorage)
        {
            _client = client;
            _localstorage = localstorage;
        }
    }
}
