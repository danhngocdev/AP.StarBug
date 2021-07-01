using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace AP.StarBug.Core.Service
{
   public interface IDapperRepository
    {
        T execute_sp<T>(string query, DynamicParameters sp_params, CommandType commandType = CommandType.StoredProcedure);
        List<T> GetAll<T>(string query, DynamicParameters sp_params, CommandType commandType = CommandType.StoredProcedure);
    }
}

