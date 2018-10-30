﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using NHibernate_PostGreSQLDAL.Entities;

namespace NHibernate_PostGreSQLDAL.Mapping
{
    public class Capabilidade_maquinafabricacaoMap : ClassMap<Capabilidade_maquinafabricacao>
    {
        public Capabilidade_maquinafabricacaoMap()
        {
            Id(f => f.id);
            Map(f => f.maquinafabricacao);
            Table("capabilidade_maquinafabricacao");
        }
    }
}
