using Modelo;
using Persistencia;
using System;
using System.Collections.Generic;
using System.Text;

namespace Servicos
{
    public class DataBaseCreate
    {
        public static void CreateDataBase()
        {
            using (EFContext context = new EFContext())
            {
                //context.Database.EnsureDeleted();
                context.Database.EnsureCreated();
            }
        }
    }
}
