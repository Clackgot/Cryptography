using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cryptography_1
{
	class FourthCipher
	{
		private static string Alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyzАБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯабвгдеёжзийклмнопрстуфхцчшщъыьэюя";//Набор сиволов
		public string text = "";
		private string firstKey = "";
		private string secondKey = "";
		string NewAlphabet = Alphabet;

		private string encrypt;//Зашифрованные данные
		private string decrypt;//Дешифрованные данные

		public int height;//Высота
		private int width;//Широта

		private char [,] Table;//Таблица

		public FourthCipher(string text, string firstKey, string secondKey, out int Height, out string Alphabet)
		{
			this.text = text;//Исходный текст
			this.firstKey = firstKey;//Первый ключ
			this.secondKey = secondKey;//Второй ключ
			this.width = firstKey.Length;//Ширина таблицы
			this.height = (int)Math.Ceiling(Convert.ToDouble(text.Length) / Convert.ToDouble(width));//Высота таблицы
			this.Table = new char[height,width];//Таблица
			Height = height;//Возвращаем высоту таблицы
			Alphabet = NewAlphabet;//Возвращаем алфавит
		}

		//Заполнение Таблицы
		private void FillTable()
		{
			for (int i = 0, n = 0; i < height; i++)
			{
				for (int j = 0; j < width; j++)
				{
					Table[i, j] = (text.Length == n) ? ' ' : text[n++];
				}
			}
		}


		//Проверка ключа на число и запись в численный массив
		public int[] ConvertToNumber(string key)
		{
			int[] NumberKey = new int[key.Length];
			bool IsNumber = int.TryParse(key.Trim(), out int number);
			if (IsNumber)
			{
				string str = number.ToString();
				for (int i = 0; i < key.Length; i++)
				{
					NumberKey[i] = Convert.ToInt32(str[i]);
				}
			}
			else
			{
				for (int i = 0; i < key.Length; i++)//Перебираем все символы ключа
				{
					NumberKey[i] = Alphabet.IndexOf(key[i]);
				}
			}
			//Например 64287
			// -->  32154

			//int[] NewNumberKey = NumberKey;
			
			int[] NewNumberKey;
			foreach (var key in NumberKey)
			{
				NewNumberKey.Add(key);
			}
			//Array.Sort(NumberKey);
			
			//for (int i = 0; i < NumberKey.Length; i++)
			//{
			//	NumberKey[i] = Array.IndexOf(NewNumberKey, NumberKey[i])+1;
			//}
			return NewNumberKey;
		}







		//Корректировка горизонтальных индексов
		private void CorrectFirstKey()
		{
			
		}

		//Корректировка вертикальных индексов
		private void CorrectSecondKey()
		{

		}

		//Основные действия
		private void CipherDerivation()
		{

		}
	}
}
