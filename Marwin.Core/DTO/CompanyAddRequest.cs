﻿using Marwin.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marwin.Core.DTO
{
    public class CompanyAddRequest
    {
        /// <summary>
        /// Наименование компании
        /// </summary>
        public string CompanyName { get; set; }
        /// <summary>
        /// БИН компании
        /// </summary>
        public string BIN { get; set; }
        /// <summary>
        /// Физический адрес компании
        /// </summary>
        public string Address { get; set; }
        /// <summary>
        /// Примечание
        /// </summary>
        public string Note { get; set; }

        public Company ToCompany()
        {
            return new Company
            { 
                CompanyName = CompanyName,
                Address = Address,
                BIN = BIN,
                Note = Note
            };
        }
    }
}