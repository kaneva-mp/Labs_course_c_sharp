using System;
using System.Collections.Generic;

namespace Lab_4
{
    /// <summary>
    /// Интерфейс конфигурации в зависимости от языка
    /// </summary>
    public interface LanguageConfig
    {
        /// <summary>
        /// Язык
        /// </summary>
        public string language { get; set; }
        /// <summary>
        /// Автоматическое закрытие скобок
        /// </summary>
        public bool autoClosingBrackets { get; set; }
        /// <summary>
        /// Предложить продолжение для слов - триггеров
        /// </summary>
        public bool suggestOnTriggerCharacters { get; set; }
        /// <summary>
        /// Предложить продолжение для слов
        /// </summary>
        public bool wordBasedSuggestions { get; set; }
        /// <summary>
        /// Вставка фрагментов при совпадении их префиксов
        /// </summary>
        public bool tabCompletion { get; set; }
        /// <summary>
        /// Выделение текущей строки
        /// </summary>
        public bool selectionHighlight { get; set; }
        /// <summary>
        /// Определяет, должны ли в редакторе отображаться направляющие отступа
        /// </summary>
        public bool renderIndentGuides { get; set; }
        /// <summary>
        /// Определяет, должен ли редактор отображать текущее выделение строки
        /// </summary>
        public bool renderLineHighlight { get; set; }
        /// <summary>
        /// Определяет, включено ли сворачивание кода в редакторе
        /// </summary>
        public bool folding { get; set; }
        /// <summary>
        /// Автосохранение
        /// </summary>
        public bool autoSave { get; set; }

        /// <summary>
        /// Вывести в консоль конфигурацию
        /// </summary>
        public void printConfig();
    }
}