using System;

namespace SimpleRandomizer
{
	/// <summary>
	/// Класс генерирует всякие псевдо-случайности
	/// </summary>
    public class Randomizer
    {
		/// <summary>
		/// Экземпляр класса <see cref="Random"/>
		/// </summary>
		readonly Random _generator = new Random();

		/// <summary>
		/// Генератор псевдо-случайного числа от 0 до 100
		/// </summary>
		/// <returns></returns>
		public int GenerateInt()
		{
			return GenerateInt(0, 100);
		}

		/// <summary>
		/// Генератор псевдо-случайного числа от 0
		/// </summary>
		/// <param name="maxValue">Максимальное значение</param>
		/// <returns></returns>
		public int GenerateInt(int maxValue = 100)
		{
			return GenerateInt(0, maxValue);
		}

		/// <summary>
		/// Генератор псевдо-случайного числа
		/// </summary>
		/// <param name="minValue">Минимльное значение</param>
		/// <param name="maxValue">Максимальное значение</param>
		/// <returns></returns>
		public int GenerateInt(int minValue = 0, int maxValue=100)
		{
			var result = _generator.Next(minValue, maxValue);

			return result;
		}

		/// <summary>
		/// Функция генерирует случайную строку
		/// </summary>
		/// <param name="counter">Количество символов</param>
		/// <returns></returns>
		public string GenerateString(int counter = 6)
		{
			var result = "";

			for (var i = 0; i < counter; i++)
			{
				var code = GenerateInt(97, 122);
				result = result + (char) code;
			}
			return result;
		}
    }
}
