using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace УП_МДК_01_01
{
    
    internal class Authorization
    {
        static public string    Права_доступа, Клиент, Агент, Администратор, Оператор, Гость ;
            
        static public void Authorization1(string Логин, string Пароль)
        {
            try
            {
                DBConnection.sqlCommand.CommandText = @"SELECT Права_доступ from Пользователи WHERE Логин = '" + Логин + "' and Пароль = '" + Пароль + "' ";
                Object result = DBConnection.sqlCommand.ExecuteScalar();
                if(result != null)
                {
                    Права_доступа = result.ToString();
                    Клиент = Логин;
                    Агент  = Логин;
                    Администратор = Логин;
                    Оператор = Логин;
                    Гость = Логин;
                }
                else
                {
                    Права_доступа = null;
                 
                }
            }
            catch
            {
                Права_доступа = Клиент = null;
                Права_доступа = Агент = null;
                Права_доступа = Администратор = null;
                Права_доступа = Оператор = null;
                Права_доступа = Гость = null;
                MessageBox.Show("Ошибка при входе");
            }
        }
        static public string AuthorizationName(string Логин)
        {
            try
            {
             DBConnection.sqlCommand.CommandText = @"SELECT Право_доступа FROM Пользователи WHERE Логин = '" + Логин + "' ";
                Object result = DBConnection.sqlCommand.ExecuteScalar();
                Права_доступа = result.ToString();
                return Права_доступа;
            }
             catch
            {
                return null;
            }
        }

    }
}
