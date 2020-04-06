using System;
namespace Lab_4
{
    /// <summary>
    /// Класс редактор кода
    /// </summary>
    public class CodeEditor
    {
        /// <summary>
        /// Полное имя файла
        /// </summary>
        private string fileName;
        /// <summary>
        /// Конфигурация редактора
        /// </summary>
        private LanguageConfig configuration;
        /// <summary>
        /// КОнфигуратор для определенного языка
        /// </summary>
        private Configurator configurator;

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="configurator"> Конфигуратор для определенного языка </param>
        /// <param name="fileName"> Имя файла </param>
        public CodeEditor(Configurator configurator, string fileName)
        {
            this.fileName = fileName;
            this.configurator = configurator;
            this.configuration = configurator.createConfiguration();
        }

        /// <summary>
        /// Вывести на экран конфигурацию
        /// </summary>
        public void showConfig()
        {
            configuration.printConfig();
        }

    }
}
