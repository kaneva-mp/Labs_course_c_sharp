using System;
namespace Lab_4
{
    /// <summary>
    /// Конфигуратор для языка SQL
    /// </summary>
    public class SQLConfigurator: Configurator
    {
        /// <summary>
        /// Создание конфигураторации для языка SQL
        /// </summary>
        /// <returns> Конфигурация, в зависимости от языка </returns>
        public LanguageConfig createConfiguration()
        {
            return new ConfigSQL();
        }

        /// <summary>
        /// Конструктор
        /// </summary>
        public SQLConfigurator()
        {
        }
    }
}
