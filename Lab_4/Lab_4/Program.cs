using System;

namespace Lab_4
{
    class Program
    {
        /// <summary>
        /// Точка входа
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            string filename = "file.cs";
            string fileFormat = filename.Substring(filename.IndexOf('.') + 1);
            Configurator configurator;

            try
            {
                switch (fileFormat)
                {
                    case "cs":
                        configurator = new CSharpConfigurator();
                        break;
                    case "sql":
                        configurator = new SQLConfigurator();
                        break;
                    case "html":
                        configurator = new HTMLConfigurator();
                        break;
                    default:
                        throw new ArgumentException();
                }

                CodeEditor editor = new CodeEditor(configurator, filename);
                editor.showConfig();
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Only .html, .cs, .sql");
            }
            catch
            {
                Console.WriteLine("Some error");
            }
        }
    }
}
