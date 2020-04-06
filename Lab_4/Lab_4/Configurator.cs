using System;
namespace Lab_4
{
    /// <summary>
    /// Интерфейс конфигуратор
    /// </summary>
    public interface Configurator
    {
        /// <summary>
        /// Создать конфигурацию
        /// </summary>
        /// <returns> Конфигурация, в зависимости от языка </returns>
        public LanguageConfig createConfiguration();
    }
}
