using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimpleRandomizer;

namespace SimpleRandomizer.Tests
{
	[TestClass]
	public class RandomizerTest
	{
		public SimpleRandomizer.Randomizer _randomizer = new SimpleRandomizer.Randomizer();

		[TestMethod]
		public void GenerateIntGlobalTest()
		{
			var someValue = _randomizer.GenerateInt();

			Assert.IsNotNull(someValue, "Число без параметров не генерируется");

			someValue = _randomizer.GenerateInt(100);

			Assert.IsNotNull(someValue, "Простое число не генерируется");

			someValue = _randomizer.GenerateInt(0, 100);

			Assert.IsNotNull(someValue, "Число в диапозоне не генерируется");
		}

		[TestMethod]
		public void GenerateIntArrayTest()
		{
			int minValue = 100;
			int maxValue = 0;
			bool result = false;
			for (int i = 0; i < 1000; i++)
			{
				var someValue = _randomizer.GenerateInt(0, 100);

				if (someValue < minValue) minValue = someValue;
				if (someValue > maxValue) maxValue = someValue;
			}
			if (minValue >= 0 && minValue < 100)
			{
				if (maxValue <= 100 && maxValue > 0)
				{
					result = true;
				}
			}

			Assert.IsTrue(result, "Ошибка генерации в диапозоне");
		}

		[TestMethod]
		public void GenerateStringTest()
		{
			var newString = _randomizer.GenerateString(6);
		
			Assert.IsTrue((newString.Length==6), "Ошибка формирования случайной строки");
		}
	}
}
