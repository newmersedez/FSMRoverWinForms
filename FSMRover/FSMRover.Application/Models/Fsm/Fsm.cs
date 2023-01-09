using FSMRover.Models.State;

namespace FSMRover.Models.Fsm
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
