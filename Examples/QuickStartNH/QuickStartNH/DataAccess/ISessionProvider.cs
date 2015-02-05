using System;
using NHibernate;

namespace QuickStartNH.DataAccess
{
    /// <summary>Провайдер сессий NHibernate</summary>
    public interface ISessionProvider : IDisposable
    {
        /// <summary>Получить текущую сессию (Внимание! Используется только для проверки наличия сессии или получения доступа к текущей. Служит индиктаром наличия открытой сессии)</summary>
        /// <returns>Текущая сессия</returns>
        ISession CurrentSession { get; }

        /// <summary>Открыть "независимую/тихую" сессию (Не вызываются различные события  NHibernate)</summary>
        /// <param name="dbKey">Ключ базы данных</param>
        /// <returns>Сессия</returns>
        IStatelessSession OpenStatelessSession(string dbKey = null);

        /// <summary>Получить текущую сессию (в случае отсутствия, сессия создается)</summary>
        /// /// <param name="dbKey">Ключ базы данных</param>
        /// <returns>Текущая сессия</returns>
        ISession GetCurrentSession(string dbKey = null);

        /// <summary>Закрыть текущую сессию (Внимание!!! Вызывать вне транзакции. При вызове внутри открытой транзакции можем получить различные непрогнозируемые ошибки!!!)</summary>
        void CloseCurrentSession(string dbKey = null);

        /// <summary>Создать новую сессию (Внимание!!! Текущая сессия будет закрыта!!! Вызывать вне транзакции. При вызове внутри открытой транзакции можем получить различные непрогнозируемые ошибки!!!)</summary>
        /// <param name="dbKey">Ключ базы данных</param>
        /// <returns>Новая сессия</returns>
        ISession CreateNewSession(string dbKey = null);
    }
}
