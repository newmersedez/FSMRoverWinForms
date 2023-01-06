using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FSMRover.Models.State;

namespace FSMRover.Models.Rover
{
	/// <summary>
	/// Интерфейс, представляющий Марсоход
	/// </summary>
	public interface IRover
	{
		/// <summary>
		/// Заряд батареи
		/// </summary>
		int Battery { get; set; }

		/// <summary>
		/// Хранилище
		/// </summary>
		int Storage { get; set; }

		/// <summary>
		/// Память
		/// </summary>
		int Memory { get; set; }

		/// <summary>
		/// Изучить территорию
		/// </summary>
		AllStates DiscoverArea();

		/// <summary>
		/// Собрать грунт
		/// </summary>
		AllStates CollectSoil();

		/// <summary>
		/// Сделать фото
		/// </summary>
		AllStates MakePhoto();

		/// <summary>
		/// Зарядить батарею
		/// </summary>
		AllStates ChargeBatteries();

		/// <summary>
		/// Проверить модули
		/// </summary>
		/// <returns></returns>
		AllStates FixModules();

		/// <summary>
		/// Отправить данные в центр управления
		/// </summary>
		AllStates SendData();

		/// <summary>
		/// Обновить состояние
		/// </summary>
		/// <returns></returns>
		AllStates Update();
	}
}
