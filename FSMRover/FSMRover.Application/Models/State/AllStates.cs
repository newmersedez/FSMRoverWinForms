using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Models.State
{
	/// <summary>
	/// Возможные состояния конечного автомата
	/// </summary>
	public enum AllStates
	{
		/// <summary>
		/// Изучает территорию
		/// </summary>
		DiscoverArea = 0,

		/// <summary>
		/// Собирает грунт
		/// </summary>
		CollectSoil = 1,

		/// <summary>
		/// Делает фотографию
		/// </summary>
		MakePhoto = 2,

		/// <summary>
		/// Отправляет данные в командный центр
		/// </summary>
		SendData = 3,

		/// <summary>
		/// Заряжает батареи
		/// </summary>
		ChargeBatteries = 4,

		/// <summary>
		/// Проводит диагностику модулей
		/// </summary>
		FixModules = 5,
	}
}
