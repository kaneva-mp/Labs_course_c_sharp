using System;
namespace Lab_4
{
    /// <summary>
    /// Конфигуратор для языка с#
    /// </summary>
    public class CSharpConfigurator: Configurator
    {
        /// <summary>
        /// Создание конфигураторации для языка с#
        /// </summary>
        /// <returns> Конфигурация, в зависимости от языка </returns>
        public LanguageConfig createConfiguration()
        {
            return new ConfigCSharp();
        }

        /// <summary>
        /// Конструктор
        /// </summary>
        public CSharpConfigurator()
        {
        }
    }
}
