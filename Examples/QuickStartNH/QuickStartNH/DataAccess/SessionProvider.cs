using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NHibernate;

namespace QuickStartNH.DataAccess
{
    public class SessionProvider : ISessionProvider
    {
        private ConcurrentDictionary<string, ISession> _sessionDict = new ConcurrentDictionary<string, ISession>();
        public NHibernate.ISession CurrentSession
        {
            get
            {
                ISession session;
                _sessionDict.TryGetValue(NhDatabaseConfigProvider.DefaultDatabase, out session);
                return session;
            }
        }

        public NHibernate.IStatelessSession OpenStatelessSession(string dbKey = null)
        {
            throw new NotImplementedException();
        }

        public NHibernate.ISession GetCurrentSession(string dbKey = null)
        {
            throw new NotImplementedException();
        }

        public void CloseCurrentSession(string dbKey = null)
        {
            throw new NotImplementedException();
        }

        public NHibernate.ISession CreateNewSession(string dbKey = null)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}