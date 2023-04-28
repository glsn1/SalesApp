﻿using SalesApp.Business.Abstract;
using SalesApp.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesApp.DAL.Abstract
{
    public interface IOrderDAL:IRepository<Order>
    {
    }
}