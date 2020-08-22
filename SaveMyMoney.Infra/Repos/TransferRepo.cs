﻿using Microsoft.EntityFrameworkCore;
using SaveMyMoney.Domain.Commands.Responses;
using SaveMyMoney.Domain.Entities;
using SaveMyMoney.Domain.Repos;
using SaveMyMoney.Infra.Contexts;
using System.Collections.Generic;
using System.Linq;

namespace SaveMyMoney.Infra.Repos
{
    public class TransferRepo : ITransferRepo
    {
        private readonly DataContext _context;

        public TransferRepo(DataContext context)
        {
            _context = context;
        }

        public ICollection<Transfer> GetAll()
        {
            return _context.Transfers.AsNoTracking().ToList();
        }

        public Transfer GetById(int id)
        {
            return _context.Transfers.AsNoTracking().FirstOrDefault(x => x.Id == id);
        }

        public void Save(Transfer transfer)
        {
            _context.Transfers.Add(transfer);
        }
    }
}
