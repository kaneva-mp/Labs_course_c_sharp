using System;
using System.Collections.Generic;

namespace Lab_4
{
    /// <summary>
    /// Конфигурация для файла .sql
    /// </summary>
    public class ConfigSQL: LanguageConfig
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
        /// Конструктор
        /// </summary>
        /// <param name="language">Язык</param>
        /// <param name="autoClosingBrackets">Автоматическое закрытие скобок</param>
        /// <param name="suggestOnTriggerCharacters">Предложить продолжение для слов - триггеров</param>
        /// <param name="wordBasedSuggestions">Предложить продолжение для слов</param>
        /// <param name="tabCompletion">Вставка фрагментов при совпадении их префиксов</param>
        /// <param name="selectionHighlight">Выделение текущей строки</param>
        /// <param name="renderIndentGuides">Определяет, должны ли в редакторе отображаться направляющие отступа</param>
        /// <param name="renderLineHighlight">Определяет, должен ли редактор отображать текущее выделение строки</param>
        /// <param name="autoSave">Автосохранение</param>
        /// <param name="folding">Определяет, включено ли сворачивание кода в редакторе</param>
        public ConfigSQL(string language,
                                bool autoClosingBrackets,
                                bool suggestOnTriggerCharacters,
                                bool wordBasedSuggestions,
                                bool tabCompletion,
                                bool selectionHighlight,
                                bool renderIndentGuides,
                                bool renderLineHighlight,
                                bool autoSave,
                                bool folding)
        {
            this.language = language;
            this.autoClosingBrackets = autoClosingBrackets;
            this.suggestOnTriggerCharacters = suggestOnTriggerCharacters;
            this.wordBasedSuggestions = wordBasedSuggestions;
            this.tabCompletion = tabCompletion;
            this.selectionHighlight = selectionHighlight;
            this.renderIndentGuides = renderIndentGuides;
            this.renderLineHighlight = renderLineHighlight;
            this.autoSave = autoSave;
            this.folding = folding;
        }

        /// <summary>
        /// Конфигурация по умолчанию
        /// </summary>
        public ConfigSQL()
        {
            this.language = "sql";
            this.autoClosingBrackets = false;
            this.suggestOnTriggerCharacters = true;
            this.wordBasedSuggestions = false;
            this.tabCompletion = false;
            this.selectionHighlight = true;
            this.renderIndentGuides = false;
            this.renderLineHighlight = true;
            this.autoSave = true;
            this.folding = true;
        }

        /// <summary>
        /// Вывести в консоль конфигурацию
        /// </summary>
        public void printConfig()
        {
            Console.WriteLine("Language = " + language);
            Console.WriteLine("autoClosingBrackets = " + autoClosingBrackets);
            Console.WriteLine("suggestOnTriggerCharacters = " + suggestOnTriggerCharacters);
            Console.WriteLine("wordBasedSuggestions = " + wordBasedSuggestions);
            Console.WriteLine("tabCompletion = " + tabCompletion);
            Console.WriteLine("selectionHighlight = " + selectionHighlight);
            Console.WriteLine("renderIndentGuides = " + renderIndentGuides);
            Console.WriteLine("renderLineHighlight = " + renderLineHighlight);
            Console.WriteLine("autoSave = " + autoSave);
            Console.WriteLine("folding = " + folding);
        }
    }
}
