using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Models.State;

namespace WindowsFormsApp1.Models.Fsm
{
	/// <summary>
	/// Класс конечного автомата
	/// </summary>
	public sealed class Fsm : IFsm
	{
		/// <summary>
		/// Текущее состояние
		/// </summary>
		public ActionState CurrentState { get; set; }

		/// <summary>
		/// Установить состояние
		/// </summary>
		/// <param name="state">Состояние</param>
		public void SetState(ActionState state)
		{
			CurrentState = state;
		}

		/// <summary>
		/// Обновить состояние
		/// </summary>
		public AllStates Update()
		{
			if (CurrentState != null)
			{
				return CurrentState();
			}

			return AllStates.DiscoverArea;
		}
	}
}
