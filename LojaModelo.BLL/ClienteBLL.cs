﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LojaModelo.Models;
using LojaModelo.DAL;

namespace LojaModelo.BLL
{
    public class ClienteBLL : IClienteDados
    {
        public void Alterar(Cliente cliente)
        {
            throw new NotImplementedException();
        }

        public void Excluir(string Id)
        {
            throw new NotImplementedException();
        }

        public void Incluir(Cliente cliente)
        {
            if (string.IsNullOrEmpty(cliente.Nome))
            {
                throw new ApplicationException("O nome deve ser informado");
            }

            if (string.IsNullOrEmpty(cliente.Email))
            {
                throw new ApplicationException("O Email deve ser informado");
            }

            if (string.IsNullOrEmpty(cliente.Id))
            {
                cliente.Id =
                    Guid.NewGuid().ToString();   
            }

            var dal = new ClienteDAL();
            dal.Incluir(cliente);
        }

        public Cliente ObterPorEmail(string email)
        {
            throw new NotImplementedException();
        }

        public Cliente ObterPorId(string id)
        {
            throw new NotImplementedException();
        }

        public List<Cliente> ObterTodos()
        {
            throw new NotImplementedException();
        }
    }
}
