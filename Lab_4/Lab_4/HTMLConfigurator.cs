using System;
namespace Lab_4
{
    /// <summary>
    /// Конфигуратор для языка html
    /// </summary>
    public class HTMLConfigurator: Configurator
    {
        /// <summary>
        /// Создание конфигураторации для языка HTML
        /// </summary>
        /// <returns> Конфигурация, в зависимости от языка </returns>
        public LanguageConfig createConfiguration()
        {
            return new ConfigHTML();
        }

        /// <summary>
        /// Конструктор
        /// </summary>
        public HTMLConfigurator()
        {
        }
    }
}
