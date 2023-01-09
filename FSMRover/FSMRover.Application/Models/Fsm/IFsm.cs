using FSMRover.Models.State;

namespace FSMRover.Models.Fsm
{
	/// <summary>
	/// Делегат для вызова обработчика состояния
	/// </summary>
	/// <returns></returns>
	public delegate AllStates ActionState();

	/// <summary>
	/// Интерфейс конечного автомата
	/// </summary>
	public interface IFsm
	{
		/// <summary>
		/// Текущее состояние
		/// </summary>
		ActionState CurrentState { get; set; }

		/// <summary>
		/// Установить состояние
		/// </summary>
		/// <param name="state">Состояние</param>
		void SetState(ActionState state);
		
		/// <summary>
		/// Обновить состояние
		/// </summary>
		AllStates Update();
	}
}
