using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Models.State;

namespace WindowsFormsApp1.Models.Rover
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
		/// Отправить данные в центр управления
		/// </summary>
		AllStates SendData();
	}
}
