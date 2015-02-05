using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuickStartNH.DataAccess
{
    /// <summary>
    /// Интерфейс инсталлера доступа к данным.
    /// </summary>
    public interface IDataAccessInstaller
    {
        /// <summary>
        /// Проводит инсталлирование.
        /// </summary>
        void Instal();
    }
}
