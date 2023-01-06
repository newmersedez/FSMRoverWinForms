using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Models.State;

namespace WindowsFormsApp1.Models.Fsm
{
	/// <summary>
	/// Делегат для вызова обработчика состояния
	/// </summary>
	/// <returns></returns>
	public delegate AllStates ExecState();

	/// <summary>
	/// Интерфейс конечного автомата
	/// </summary>
	public interface IFsm
	{
		/// <summary>
		/// Текущее состояние
		/// </summary>
		ExecState CurrentState { get; set; }

		/// <summary>
		/// Установить состояние
		/// </summary>
		/// <param name="state">Состояние</param>
		void SetState(ExecState state);
		
		/// <summary>
		/// Обновить состояние
		/// </summary>
		void Update();
	}
}
