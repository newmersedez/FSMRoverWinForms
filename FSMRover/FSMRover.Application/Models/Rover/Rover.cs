using System;
using System.Threading;
using FSMRover.Models.Fsm;
using FSMRover.Models.State;

namespace FSMRover.Models.Rover
{
	/// <summary>
	/// Класс марсохода
	/// </summary>
	public sealed class Rover : IRover
	{
		private readonly IFsm _fsm;
		private int _battery;
		private int _memory;
		private int _storage;
		
		public AllStates CurrentState { get; set; }

		public Rover(IFsm fsm)
		{
			_fsm = fsm ?? throw new ArgumentNullException(nameof(fsm));
			_fsm.SetState(DiscoverArea);
			CurrentState = AllStates.DiscoverArea;
			
			Battery = 100;
			Storage = 0;
			Memory = 0;
		}

		/// <summary>
		/// Заряд батареи
		/// </summary>
		public int Battery
		{
			get => _battery;
			set
			{
				_battery = value;
				if (_battery < 0) _battery = 0;
			}
		}

		/// <summary>
		/// Хранилище
		/// </summary>
		public int Storage
		{
			get => _storage;
			set
			{
				_storage = value;
				if (_storage > 10) _storage = 10;
			}
		}
		
		/// <summary>
		/// Память
		/// </summary>
		public int Memory
		{
			get => _memory;
			set
			{
				_memory = value;
				if (_memory > 10) _memory = 10;
			}
		}

		/// <summary>
		/// Изучить территорию
		/// </summary>
		/// <returns></returns>
		public AllStates DiscoverArea()
		{
			CurrentState = AllStates.DiscoverArea;
			
			if (Battery <= 10)
			{
				_fsm.SetState(ChargeBatteries);
				return AllStates.ChargeBatteries;
			}

			var random = new Random();
			if (random == null) throw new ArgumentNullException(nameof(random));

			Battery -= random.Next(3, 20);

			if (Storage < 10)
			{
				_fsm.SetState(CollectSoil);
				return AllStates.CollectSoil;
			}

			_fsm.SetState(FixModules);
			return AllStates.FixModules;
		}

		/// <summary>
		/// Зарядить батареи
		/// </summary>
		public AllStates ChargeBatteries()
		{
			CurrentState = AllStates.ChargeBatteries;
			
			Battery = 100;
			_fsm.SetState(DiscoverArea);
			return AllStates.DiscoverArea;
		}

		/// <summary>
		/// Собрать грунт
		/// </summary>
		/// <returns></returns>
		public AllStates CollectSoil()
		{
			CurrentState = AllStates.CollectSoil;
			var random = new Random();
			if (random == null) throw new ArgumentNullException(nameof(random));

			Storage += random.Next(1, 5);
			Battery -= random.Next(1, 10);

			if (Memory < 10)
			{
				_fsm.SetState(MakePhoto);
				return AllStates.MakePhoto;
			}

			_fsm.SetState(FixModules);
			return AllStates.FixModules;
		}

		/// <summary>
		/// Проверить модули
		/// </summary>
		/// <returns></returns>
		public AllStates FixModules()
		{
			CurrentState = AllStates.FixModules;
			
			if (Battery <= 5 || Storage == 10 || Memory == 10)
			{
				Memory = 0;
				Storage = 0;

				_fsm.SetState(ChargeBatteries);
				return AllStates.ChargeBatteries;
			}

			_fsm.SetState(DiscoverArea);
			return AllStates.DiscoverArea;
		}

		/// <summary>
		/// Сделать фото
		/// </summary>
		/// <returns></returns>
		public AllStates MakePhoto()
		{
			CurrentState = AllStates.MakePhoto;
			
			var random = new Random();
			if (random == null) throw new ArgumentNullException(nameof(random));

			Memory += random.Next(1, 3);
			Battery -= random.Next(1, 5);

			var signal = random.Next(0, 2);
			if (signal == 0)
			{
				_fsm.SetState(DiscoverArea);
				return AllStates.DiscoverArea;
			}

			_fsm.SetState(SendData);
			return AllStates.SendData;
		}

		/// <summary>
		/// Отправить данные в центр управления
		/// </summary>
		/// <returns></returns>
		public AllStates SendData()
		{
			CurrentState = AllStates.SendData;
			
			var random = new Random();
			if (random == null) throw new ArgumentNullException(nameof(random));

			Battery -= random.Next(3, 10);

			if (Battery <= 20)
			{
				_fsm.SetState(ChargeBatteries);
				return AllStates.ChargeBatteries;
			}
	
			_fsm.SetState(DiscoverArea);
			return AllStates.DiscoverArea;
	
		}

		/// <summary>
		/// Обновить состояние
		/// </summary>
		/// <returns></returns>
		public AllStates Update()
		{
			_fsm.Update();
			Thread.Sleep(1000);
			return CurrentState;
		}
	}
}
