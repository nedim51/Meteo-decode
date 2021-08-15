using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meteo_decode
{
    // Класс для работы с хранилищем приложения
    class PropStorage
    {
        // Устанавливает строковое значение в хранилище по ключу 
        public static void SetValue(string key, string value)
        {
            Properties.Default[key] = value;
            Properties.Default.Save();
        }

        // Устанавливает булево значение в хранилище по ключу 
        public static void SetValue(string key, bool value)
        {
            Properties.Default[key] = value;
            Properties.Default.Save();
        }

        // Возвращает строковое значение из хранилища по ключу
        public static string GetStrValue(string key)
        {
            return Properties.Default[key].ToString();
        }

        // Возвращает строковое значение из хранилища по ключу
        public static bool GetBoolValue(string key)
        {
            return Convert.ToBoolean(Properties.Default[key]);
        }
    }
}
