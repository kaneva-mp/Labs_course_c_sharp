using System;
using System.Collections.Generic;

namespace Lab5
{
    /// <summary>
	/// Класс наружного освещения
	/// </summary>
    public class LightOutside
    {
        /// <summary>
		/// Интенсивность света
		/// </summary>
        private int intensity = 1;

        /// <summary>
		/// Конструктор
		/// </summary>
        public LightOutside() { }

        /// <summary>
		/// Функция включения света
		/// </summary>
        public void switchOn()
        {
            Console.WriteLine("Ligth's switched on");
        }

        /// <summary>
		/// Функция выключения света
		/// </summary>
        public void switchOff()
        {
            Console.WriteLine("Ligth's switched off");
        }
    }

    /// <summary>
	/// Класс терморегуляции
	/// </summary>
    public class HeatingCooling
    {
        /// <summary>
		/// Текущая температура
		/// </summary>
        private double temperature = 20.5;

        /// <summary>
		/// Конструктор
		/// </summary>
        public HeatingCooling() { }

        /// <summary>
		/// Режим негрева или охлаждения
		/// </summary>
        private string mode
        {
            get
            {
                return temperature >= 23 ? "cooling" : "heating";
            }

        }

        /// <summary>
		/// Запуск системы терморегуляции
		/// </summary>
        public void start()
        {
            Console.WriteLine("Start " + mode);
        }

        /// <summary>
		/// Остановка системы терморегуляции
		/// </summary>
        public void stop()
        {
            Console.WriteLine("Stop " + mode);
        }
    }

    /// <summary>
	/// Интерфейс команда
	/// </summary>
    public interface Command
    {
        /// <summary>
		/// Выполнение команды
		/// </summary>
        public void execute();
    }

    /// <summary>
	/// Команда включения наружного освещения
	/// </summary>
    public class SwitchOnLightCommand: Command
    {
        /// <summary>
		/// Наружнее освещение 
		/// </summary>
        private LightOutside light = new LightOutside();

        /// <summary>
		/// Конструктор
		/// </summary>
		/// <param name="light">Наружное освещение</param>
        public SwitchOnLightCommand(LightOutside light)
        {
            this.light = light;
        }

        /// <summary>
		/// Выполнение команды
		/// </summary>
        public void execute()
        {
            light.switchOn();
        }
    }

    /// <summary>
	/// Команда включения обогрева
	/// </summary>
    public class StartHeatingCommand: Command
    {
        /// <summary>
		/// Терморегулятор
		/// </summary>
        private HeatingCooling heater = new HeatingCooling();

        /// <summary>
		/// Конструктор
		/// </summary>
		/// <param name="heater">Терморегулятор</param>
        public StartHeatingCommand(HeatingCooling heater)
        {
            this.heater = heater;
        }

        /// <summary>
		/// Выполнение команды
		/// </summary>
        public void execute()
        {
            heater.start();
        }
    }

    /// <summary>
	/// Программа
	/// </summary>
    public class Program
    {
        /// <summary>
		/// Список команд программы
		/// </summary>
        private List<Command> commands = new List<Command>();

        /// <summary>
		/// Запуск программы
		/// </summary>
        public void start()
        {
            foreach (Command com in commands)
            {
                com.execute();
            }
        }

        /// <summary>
		/// Добавление команды в список
		/// </summary>
		/// <param name="com"></param>
        public void addCommand(Command com)
        {
            commands.Add(com);
        }
    }

    /// <summary>
	/// Клиент
	/// </summary>
    public class Client
    {
        /// <summary>
		/// Вечерняя программа
		/// </summary>
        static Program eveningProgram = new Program();
        /// <summary>
		/// Наружное освещение
		/// </summary>
        static LightOutside light = new LightOutside();
        /// <summary>
		/// Терморегулятор
		/// </summary>
        static HeatingCooling heating = new HeatingCooling();

        /// <summary>
		/// Точка входа в приложение
		/// </summary>
		/// <param name="args"></param>
        static void Main(string[] args)
        {
            try
            {
                SwitchOnLightCommand lightOnCommand = new SwitchOnLightCommand(light);
                StartHeatingCommand heatCommand = new StartHeatingCommand(heating);

                eveningProgram.addCommand(lightOnCommand);
                eveningProgram.addCommand(heatCommand);
            }
            catch
            {
                Console.WriteLine("Something goes wrong");
            }

            eveningProgram.start();
        }
    }
}
