﻿// Copyright © 2013 Open Octopus Ltd.
// 
// This program is free software; you can redistribute it and/or modify
// it under the terms of the GNU Lesser General Public License as published by
// the Free Software Foundation; either version 2 of the License, or
// (at your option) any later version.
// 
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU Lesser General Public License for more details.
// 
// You should have received a copy of the GNU Lesser General Public License along
// with this program; if not, write to the Free Software Foundation, Inc.,
// 51 Franklin Street, Fifth Floor, Boston, MA 02110-1301 USA.
// 
// Website: http://www.opencbs.com
// Contact: contact@opencbs.com

using System.Collections.Generic;
using System.Data;
using Dapper;
using DapperExtensions;
using OpenCBS.GUI.NEW.Model;

namespace OpenCBS.GUI.NEW.Repository
{
    public abstract class Repository<T> : IRepository<T> where T : EntityBase
    {
        private readonly IConnectionProvider _connectionProvider;

        protected Repository(IConnectionProvider connectionProvider)
        {
            _connectionProvider = connectionProvider;
        }

        protected IDbConnection GetConnection()
        {
            return _connectionProvider.GetConnection();
        }

        public virtual IEnumerable<T> FindAll()
        {
            using (var connection = GetConnection())
            {
                return connection.GetList<T>();
            }
        }

        public virtual IEnumerable<T> FindNonDeleted()
        {
            using (var connection = GetConnection())
            {
                var predicate = Predicates.Field<T>(t => t.Deleted, Operator.Eq, false);
                return connection.GetList<T>(predicate);
            }
        }

        public virtual T FindById(int id)
        {
            using (var connection = GetConnection())
            {
                return connection.Get<T>(id);
            }
        }

        public virtual void Update(T entity)
        {
            using (var connection = GetConnection())
            {
                connection.Update(entity);
            }
        }

        public virtual void Add(T entity)
        {
            using (var connection = GetConnection())
            {
                connection.Insert(entity);
            }
        }

        public virtual void Remove(T entity)
        {
            using (var connection = GetConnection())
            {
                var tableName = typeof(T).Name;
                if (tableName.EndsWith("Dto"))
                    tableName = tableName.Substring(0, tableName.Length - 3);
                connection.Execute("UPDATE " + tableName + " SET Deleted = 1 WHERE Id = @Id", new { entity.Id });
            }
        }
    }
}
