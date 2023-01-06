using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Models.Fsm;
using WindowsFormsApp1.Models.State;

namespace WindowsFormsApp1.Models.Rover
{
	/// <summary>
	/// Класс марсохода
	/// </summary>
	public sealed class Rover : IRover
	{
		private readonly IFsm _fsm;

		public Rover(IFsm fsm)
		{
			_fsm = fsm ?? throw new ArgumentNullException(nameof(fsm));
			_fsm.SetState(DiscoverArea);

			Battery = 100;
			Storage = 0;
			Memory = 0;
		}

		/// <summary>
		/// Заряд батареи
		/// </summary>
		public int Battery { get; set; }

		/// <summary>
		/// Хранилище
		/// </summary>
		public int Storage { get; set; }
		
		/// <summary>
		/// Память
		/// </summary>
		public int Memory { get; set; }

		/// <summary>
		/// Изучить территорию
		/// </summary>
		/// <returns></returns>
		public AllStates DiscoverArea()
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Зарядить батареи
		/// </summary>
		public AllStates ChargeBatteries()
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Собрать грунт
		/// </summary>
		/// <returns></returns>
		public AllStates CollectSoil()
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Сделать фото
		/// </summary>
		/// <returns></returns>
		public AllStates MakePhoto()
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Отправить данные в центр управления
		/// </summary>
		/// <returns></returns>
		public AllStates SendData()
		{
			throw new NotImplementedException();
		}
	}
}
