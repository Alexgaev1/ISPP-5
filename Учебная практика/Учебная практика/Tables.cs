using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Учебная_практика
{
    public partial class Tables : Form
    {
        string pic; //Путь картинки для таблицы "Абитуриент"
        string[] t = new string[15]; //Текстовый массив обозначающий данные находящиеся в textBox'ах
        string pr; //Переменная, к которой будет присваиваться права доступа
        int tabl = 0, //Переменная, которая отслеживает номер открытой таблицы
        prost = 0;//Переменная, которая отслеживает "поворот" textBox'ов
        //Инициализация компонентов
        public Tables() {InitializeComponent();}
        //Передача прав доступа из формы входа
        public void pravoo(string a){pr = a;}
        //Сохранение данных из textBox'ов в переменные
        public void textbox(int a, int b)
        {
            // Где "а" это номер таблицы, а "b" это номер "поворота"
            switch (a)
            {
                //Номера таблицы
                case 0:
                    switch (b)
                    {
                        //Номера "поворота" textBox'а
                        case 0:
                            //Присваивание
                            t[0] = TB1.Text;
                            t[1] = TB2.Text;
                            t[2] = TB3.Text;
                            t[3] = Date.Value.ToString(); //Передача даты
                            t[4] = TB5.Text;

                            break;
                        case 1:
                           
                            t[5] = TB1.Text;
                            t[6] = Date.Value.ToString();
                            t[7] = TB3.Text;
                            t[8] = TB4.Text;
                            t[9] = TB5.Text;
                            break;
                        case 2:
                            t[10] = TB1.Text;
                            t[11] = Date.Value.ToString();
                            t[14] = TB5.Text;
                           
                            break;
                    }
                    break;
                case 1:
                    switch (b)
                    {
                        case 0:
                            t[0] = TB1.Text;
                            t[1] = TB2.Text;
                            t[2] = TB3.Text;
                            t[3] = TB4.Text;
                            break;
                    }
                    break;
                case 2:
                    switch (b)
                    {
                        case 0:
                            t[0] = TB1.Text;
                            t[1] = TB2.Text;
                            t[2] = TB3.Text;
                            t[3] = TB4.Text;
                            break;
                    }
                    break;
                case 3:
                    switch (b)
                    {
                        case 0:
                            t[0] = TB1.Text;
                            t[1] = TB2.Text;
                            t[2] = TB3.Text;
                            t[3] = TB4.Text;
                            t[4] = TB5.Text;
                            break;
                        case 1:
                            t[5] = TB1.Text;
                            t[6] = TB2.Text;
                            t[7] = TB3.Text;
                            break;
                    }
                    break;
                case 4:
                    switch (b)
                    {
                        case 0:
                            t[0] = TB1.Text;
                            t[1] = TB2.Text;
                            break;
                    }
                    break;
                case 5:
                    switch (b)
                    {
                        case 0:
                            t[0] = TB1.Text;
                            t[1] = TB2.Text;
                            t[2] = TB3.Text;
                            t[3] = TB4.Text;
                            t[4] = TB5.Text;
                            break;
                        case 1:
                            t[5] = TB1.Text;
                            t[6] = TB2.Text;
                            break;
                    }
                    break;
            }
        }
        //Система "поворота" textBox'ов
        public void kryt(int a, int b)
        {
            // Где "а" это номер таблицы, а "b" это номер "поворота"
            SqlConnection sqlConnect = new SqlConnection("Data Source=sql;Initial Catalog = уП_ ПМ01_Попов_СЕ_Приемная_комиссия_университета; Integrated Security = True");//Введение в переменную базу данных
            sqlConnect.Open();//Открытие базы данных
            DataTable dt = new DataTable(); //Создание таблицы данных
            SqlDataAdapter da = new SqlDataAdapter();//Создание переменных для запроса на базу данных
            tabl = a; //Присваивание переменной открытую таблицу
            //Включение видимости объектов
            TB1.Visible = true;
            TB2.Visible = true;
            TB3.Visible = true;
            TB4.Visible = true;
            TB5.Visible = true;
            //Отключение видимости объектов
            PhotoAb.Visible = false;
            YesNo.Visible = false;
            PhoneNum.Visible = false;
            Date.Visible = false;
            MenuPrav.Visible = false;
            MenuOsnov.Visible = false;
            //Включение активности объектов
            ArrowLeft.Enabled = true;
            ArrowRight.Enabled = true;
            TB1.Enabled = true;
            TB2.Enabled = true;
            TB3.Enabled = true;
            TB4.Enabled = true;
            TB5.Enabled = true;
            //Если открыта таблица "Абитуриенты"
            if (tabl == 0)
            {
                //Если фото присутствует
                if (PhotoAbPicture.Image != null)
                {
                    Size = new Size(854, 446);
                    PhotoAbPicture.Visible = true;
                    label6.Visible = true;
                }
                //Если иной результат
                else
                {
                    Size = new Size(635, 446);
                    PhotoAbPicture.Visible = false;
                    label6.Visible = false;
                }
            }
            //Если человек зашел с доступом "Сотрудник"
            if ((pr == "personal")&&(tabl!=4))
            {
                //Деактивация объектов
                Create.Enabled = false;
                Delete.Enabled = false;
                Update.Enabled = false;
                TB1.Enabled = false;
                TB2.Enabled = false;
                TB3.Enabled = false;
                TB4.Enabled = false;
                TB5.Enabled = false;
                YesNo.Enabled = false;
                MenuPrav.Enabled = false;
                MenuOsnov.Enabled = false;
                Date.Enabled = false;
                PhoneNum.Enabled = false;
                PhotoAb.Enabled = false;
            }
            else
            {
                //Активация объектов
                Create.Enabled = true;
                Delete.Enabled = true;
                Update.Enabled = true;
                TB1.Enabled = true;
                TB2.Enabled = true;
                TB3.Enabled = true;
                TB4.Enabled = true;
                TB5.Enabled = true;
                YesNo.Enabled = true;
                MenuPrav.Enabled = true;
                MenuOsnov.Enabled = true;
                Date.Enabled = true;
                PhoneNum.Enabled = true;
                PhotoAb.Enabled = true;
            }
            switch (a)
            {
                //Номера таблиц
                case 0:
                    switch (b)
                    {
                        //Номера "поворота" textBox'ов
                        case 0:
                            //Присваивание названий столбцов
                            NameColumn1.Text = "Имя";
                            NameColumn2.Text = "Фамилия";
                            NameColumn3.Text = "Отчество";
                            NameColumn4.Text = "Дата регистрации";
                            NameColumn5.Text = "Адрес";
                            //Присавивание к объектам элементы массива
                            TB1.Text = t[0];
                            TB2.Text = t[1];
                            TB3.Text = t[2];
                            TB4.Text = t[3];
                            Date.Value = DateTime.Parse(t[3]);
                            TB5.Text = t[4];
                            //"Появление" объекта и перемещение на нужное место
                            Date.Visible = true;
                            Date.Location = new Point(374, 233);
                            break;
                        case 1:
                            da = new SqlDataAdapter("select Enrollee.Enrolle as [Номер абитуриента] ,Name as [Имя], LastName as [Фамилия], FirthName as [Отчество], Date as [Дата регистрации], Adress as [Адрес], Enrollee.Passport as [Номер паспорта], PassportDate as [Когда выдан паспорт], Region as [Кем выдан паспорт], Enrollee.Attestat as [Номер аттестата], Middle as [Средний балл аттестата], Phone as [Номер телефона], Birth as [Дата рождения], Money as [Есть возможность оплачивать?], Picture as [Фото абитуриента] from Attestat join (Passport join Enrollee on Passport.Passport = Enrollee.Passport) on Attestat.Attestat = Enrollee.Attestat", sqlConnect);
                            da.Fill(dt);
                            NameColumn1.Text = "Номер паспорта";
                            NameColumn2.Text = "Когда выдан паспорт";
                            NameColumn3.Text = "Кем выдан паспорт";
                            NameColumn4.Text = "Номер аттестата";
                            NameColumn5.Text = "Средний балл аттестата";
                            TB1.Text = t[5];
                            TB2.Text = t[6];
                            TB3.Text = t[7];
                            TB4.Text = t[8];
                            TB5.Text = t[9];
                            Date.Visible = true;
                            Date.Location = new Point(132, 233);
                            Date.Value = Convert.ToDateTime(t[6]);
                            break;
                        case 2:
                            da = new SqlDataAdapter("select Enrollee.Enrolle as [Номер абитуриента] ,Name as [Имя], LastName as [Фамилия], FirthName as [Отчество], Date as [Дата регистрации], Adress as [Адрес], Enrollee.Passport as [Номер паспорта], PassportDate as [Когда выдан паспорт], Region as [Кем выдан паспорт], Enrollee.Attestat as [Номер аттестата], Middle as [Средний балл аттестата], Phone as [Номер телефона], Birth as [Дата рождения], Money as [Есть возможность оплачивать?], Picture as [Фото абитуриента] from Attestat join (Passport join Enrollee on Passport.Passport = Enrollee.Passport) on Attestat.Attestat = Enrollee.Attestat", sqlConnect);
                            da.Fill(dt);
                            NameColumn1.Text = "Номер телефона";
                            NameColumn2.Text = "Дата рождения";
                            NameColumn3.Text = "Есть возможность оплачивать?";
                            NameColumn4.Text = "Фото абитуриента";
                            NameColumn5.Text = "Номер абитуриента";
                            TB1.Text = t[10];
                            TB2.Text = t[11];
                            TB3.Text = t[12];
                            TB4.Text = t[13];
                            TB5.Text = t[14];
                            TB5.Enabled = false;
                            PhoneNum.Location = new Point(12, 233);
                            PhoneNum.Text = t[10];
                            PhoneNum.Visible = true;
                            Date.Visible = true;
                            Date.Location = new Point(132, 233);
                            Date.Value = Convert.ToDateTime(t[11]);
                            YesNo.Visible = true;
                            YesNo.Location = new Point(252, 233);
                            PhotoAb.Visible = true;
                            PhotoAb.Location = new Point(374, 233);
                            break;
                            //Чтобы textBox'ы "прокручивались" по кругу
                        default:
                            if (b>2)
                            {
                                prost = 0;
                            }
                            if (b < 0)
                            {
                                prost = 2;
                            }
                            kryt(a, prost);
                            break;
                    }
                    break;
                case 1:
                    switch (b)
                    {
                        case 0:
                            NameColumn1.Text = "Номер аттестата ЕГЭ";
                            NameColumn2.Text = "Номер абитуриента";
                            NameColumn3.Text = "Предметы сдачи";
                            NameColumn4.Text = "Общий балл за ЕГЭ";
                            NameColumn5.Text = "";
                            TB1.Text = t[0];
                            TB2.Text = t[1];
                            TB3.Text = t[2];
                            TB4.Text = t[3];
                            ArrowLeft.Enabled = false;
                            ArrowRight.Enabled = false;
                            TB5.Visible = false;
                            TB1.Enabled = false;
                            break;
                        default:
                            if (b != 0)
                            {
                                prost = 0;
                                kryt(a, prost);
                            }
                            ArrowLeft.Enabled = false;
                            ArrowRight.Enabled = false;
                            break;
                    }
                    break;
                case 2:
                    switch (b)
                    {
                        case 0:
                            NameColumn1.Text = "Номер контракта";
                            NameColumn2.Text = "Условия договора";
                            NameColumn3.Text = "Адрес предприятия";
                            NameColumn4.Text = "Телефон предприятия";
                            NameColumn5.Text = "Платят?";
                            TB1.Enabled = false;
                            PhoneNum.Visible = true;
                            PhoneNum.Location = new Point(374, 233);
                            PhoneNum.Text = t[3];
                            YesNo.Location = new Point(495, 233);
                            YesNo.Visible = true;
                            PhoneNum.Text = t[4];
                            TB1.Text = t[0];
                            TB2.Text = t[1];
                            TB3.Text = t[2];
                            TB4.Text = t[3];
                            TB5.Text = t[4];
                            ArrowLeft.Enabled = false;
                            ArrowRight.Enabled = false;
                            break;
                        default:
                            if (b != 0)
                            {
                                prost = 0;
                                kryt(a, prost);
                            }
                            ArrowLeft.Enabled = false;
                            ArrowRight.Enabled = false;
                            break;
                    }
                    break;
                case 3:
                    switch (b)
                    {
                        case 0:
                            NameColumn1.Text = "Номер регистрации абитуриента";
                            NameColumn2.Text = "Номер аттестата ЕГЭ";
                            NameColumn3.Text = "Факультет";
                            NameColumn4.Text = "Специальность";
                            NameColumn5.Text = "Фамилия принявшего документы";
                            TB1.Enabled = false;
                            TB1.Text = t[0];
                            TB2.Text = t[1];
                            TB3.Text = t[2];
                            TB4.Text = t[3];
                            TB5.Text = t[4];
                            break;
                        case 1:
                            NameColumn1.Text = "Рекомендация для собеседования";
                            NameColumn2.Text = "Номер контракта";
                            NameColumn3.Text = "Набрано баллов при поступлении";
                            NameColumn4.Text = "";
                            NameColumn5.Text = "";
                            TB1.Text = t[5];
                            TB2.Text = t[6];
                            TB3.Text = t[7];
                            TB4.Visible = false;
                            TB5.Visible = false;
                            YesNo.Visible = true;
                            YesNo.Location = new Point (12, 233);
                            break;
                        default:
                            if (b < 0)
                            {
                                prost = 1;
                                kryt(a, prost);
                            }
                            if (b > 1)
                            {
                                prost = 0;
                                kryt(a, prost);
                            }
                            break;
                    }
                    break;
                case 4:
                    switch (b)
                    {
                        case 0:
                            NameColumn1.Text = "Номер после зачисления";
                            NameColumn2.Text = "Номер регистрации абитуриента";
                            NameColumn3.Text = "Основа, на которой зачислен";
                            NameColumn4.Text = "";
                            NameColumn5.Text = "";
                            MenuOsnov.Location = new Point (252, 232);
                            MenuOsnov.Visible = true;
                            TB1.Enabled = false;
                            TB1.Text = t[0];
                            TB2.Text = t[1];
                            TB3.Text = t[2];
                            TB4.Visible = false;
                            TB5.Visible = false;
                            ArrowLeft.Enabled = false;
                            ArrowRight.Enabled = false;
                            break;
                        default:
                            if (b != 0)
                            {
                                prost = 0;
                                kryt(a, prost);
                            }
                            ArrowLeft.Enabled = false;
                            ArrowRight.Enabled = false;
                            break;
                    }
                    break;
                case 5:
                    switch (b)
                    {
                        case 0:
                            NameColumn1.Text = "Номер пользователя";
                            NameColumn2.Text = "Логин";
                            NameColumn3.Text = "Пароль";
                            NameColumn4.Text = "Право доступа";
                            NameColumn5.Text = "Имя";
                            TB1.Enabled = false;
                            TB1.Text = t[0];
                            TB2.Text = t[1];
                            TB3.Text = t[2];
                            TB4.Text = t[3];
                            TB5.Text = t[4];
                            MenuPrav.Visible = true;
                            MenuPrav.Location = new Point(374, 232);


                            break;
                        case 1:
                            NameColumn1.Text = "Фамилия";
                            NameColumn2.Text = "Отчество";
                            NameColumn3.Text = "";
                            NameColumn4.Text = "";
                            NameColumn5.Text = "";
                            TB1.Text = t[5];
                            TB2.Text = t[6];
                            TB3.Visible = false;
                            TB4.Visible = false;
                            TB5.Visible = false;
                            break;
                        default:
                            if (b < 0)
                            {
                                prost = 1;
                                kryt(a, prost);
                            }
                            if (b > 1)
                            {
                                prost = 0;
                                kryt(a, prost);
                            }
                            break;
                    }
                    break;
                   
            }
        }
        //Загрузка таблиц при выборе
        public void table(int a)
        {
            //Где "а" это номер таблицы
            //Если таблица называется "Абитуриент"
            if (a == 0)
            {
                //Присваивание к элементам даты (сегоднешнее число)
                t[3] = DateTime.Now.ToString();
                t[6] = DateTime.Now.ToString();
                t[11] = DateTime.Now.ToString();
            }
            //Если иной результат
            else
            {
                t[3] = "";
                t[6] = "";
                t[11] = "";
            }
            SqlConnection sqlConnect = new SqlConnection("Data Source=sql;Initial Catalog = уП_ ПМ01_Попов_СЕ_Приемная_комиссия_университета; Integrated Security = True");
            sqlConnect.Open();
            DataSet dt = new DataSet();
            //Создание массива запросов
            SqlDataAdapter[] da = new SqlDataAdapter[6];
            //Запросы для просмотра таблиц
            da[0] = new SqlDataAdapter("select Enrollee.Enrolle as [Номер абитуриента] ,Name as [Имя], LastName as [Фамилия], FirthName as [Отчество], Date as [Дата регистрации], Adress as [Адрес], Enrollee.Passport as [Номер паспорта], PassportDate as [Когда выдан паспорт], Region as [Кем выдан паспорт], Enrollee.Attestat as [Номер аттестата], Middle as [Средний балл аттестата], Phone as [Номер телефона], Birth as [Дата рождения], Money as [Есть возможность оплачивать?], Picture as [Фото абитуриента] from Attestat join (Passport join Enrollee on Passport.Passport = Enrollee.Passport) on Attestat.Attestat = Enrollee.Attestat", sqlConnect);
            da[1] = new SqlDataAdapter("select EGE.EGE as [Номер аттестата ЕГЭ], Enrollee.Enrolle as [Номер абитуриента], Lessons as [Предметы которые сдавались], Score as [Общий балл за ЕГЭ] from (Attestat join (Passport join Enrollee on Passport.Passport = Enrollee.Passport) on Attestat.Attestat = Enrollee.Attestat) join EGE on Enrollee.Enrolle = EGE.Enrolle", sqlConnect);
            da[2] = new SqlDataAdapter("select ContractID as [Номер контракта], ContractAbout as [Условия договора], ContAdress as [Адрес предприятия], ContPhone as [Телефон предприятия], Payment as [Платят?] from Contract", sqlConnect);
            da[3] = new SqlDataAdapter("select PersonID as [Номер регистрации абитуриента], EGE as [Номер аттестата ЕГЭ], Faculty as [Факультет], Speciality as [Специальность], Registrar as [Фамилия принявшего документы], Talk as [Рекомендация для собеседования], ContractID as [Номер контракта], Result as [Набрано баллов при поступлении] from Commission", sqlConnect);
            da[4] = new SqlDataAdapter("select YesID as [Номер после зачисления], PersonID as [Номер регистрации абитуриента], Type as [Основа, на которой зачислен] from Enrollment", sqlConnect);
            da[5] = new SqlDataAdapter("select Id as [Номер пользователя], Login as [Логин], Password as [Пароль], Pravo as [Право доступа], Name as [Имя], LastName as [Фамилия], FrithName as [Отчество] from Users", sqlConnect);
            //Активация запроса относительно выбранной таблицы
            da[a].Fill(dt);
            //Изменение размера формы
            Size = new Size(635, 446);
            //Визуализация запроса
            UniversalTable.DataSource = dt.Tables[0];
            //Активация метода прокрутки
            kryt(a,0);
        }
        //При нажатии на стрелку в лево
        private void ArrowLeft_Click(object sender, EventArgs e)
        {
            textbox(tabl, prost);
            kryt(tabl, prost);
            prost--;
            kryt(tabl, prost);
        }
        //При нажатии перехода на таблицу "Абитуриенты"
        private void Abityrient_Click(object sender, EventArgs e) { table(0); }
        //При нажатии перехода на таблицу "ЕГЭ абитуриента"
        private void EGE_Click(object sender, EventArgs e){table(1);}
        //При нажатии перехода на таблицу "Контракт"
        private void Contract_Click(object sender, EventArgs e){table(2);}
        //При нажатии перехода на таблицу "Комиссия"
        private void Commission_Click(object sender, EventArgs e){table(3);}
        //При нажатии перехода на таблицу "Прошедшие"
        private void Proshedshie_Click(object sender, EventArgs e) { table(4); }
        //При нажатии перехода на таблицу "Права доступа"
        private void PravaDostypa_Click(object sender, EventArgs e) { table(5); }
        //При загрузке формы
        private void Tables_Load(object sender, EventArgs e)

        {
            t[12] = "";
            YesNo.Text = "Выберите";
            MenuPrav.Text = "Выберите";
            table(0);
            kryt(0, 0);
            //Если зашел Администратор
            if (pr == "admin")
            {
                PravaDostypa.Visible = true;
            }
            //Если иной результат
            else
            {
                PravaDostypa.Visible = false;
            }
        }
        //При нажатии на кнопку "Выход"
        private void Exit_Click(object sender, EventArgs e){Application.Exit();}
        //При нажатии на кнопку "Вернуться к авторизации"
        private void ExitToAvtorization_Click(object sender, EventArgs e)
        {
            //Переход на форму авторизации
            Avtorization form = new Avtorization();
            form.Show();
            Hide();
        }
        //Метод удаления записи с таблицы
        public void del()
        {
            SqlConnection sqlConnect = new SqlConnection("Data Source=sql;Initial Catalog = уП_ ПМ01_Попов_СЕ_Приемная_комиссия_университета; Integrated Security = True");
            sqlConnect.Open();
            DataSet dt = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter();
            switch (tabl)
            {
                //Номер таблицы
                case 0:
                    try
                    {
                        //Запрос удаления
                        da = new SqlDataAdapter($"Delete from Enrollee where Enrolle = {UniversalTable.Rows[UniversalTable.SelectedCells[0].RowIndex].Cells[0].Value}; Delete from Passport where Passport = {UniversalTable.Rows[UniversalTable.SelectedCells[0].RowIndex].Cells[6].Value};Delete from Attestat where Attestat = {UniversalTable.Rows[UniversalTable.SelectedCells[0].RowIndex].Cells[9].Value};", sqlConnect);
                        //Применение запроса
                        da.Fill(dt);
                    }
                    catch
                    {
                        //Ошибка в случае сбоя
                        MessageBox.Show("Данная запись связана с другими таблицами! Удалите в других таблицах!");
                    }
                    //Загрузка общего результата удаления
                    da = new SqlDataAdapter("select Enrollee.Enrolle as [Номер абитуриента] ,Name as [Имя], LastName as [Фамилия], FirthName as [Отчество], Date as [Дата регистрации], Adress as [Адрес], Enrollee.Passport as [Номер паспорта], PassportDate as [Когда выдан паспорт], Region as [Кем выдан паспорт], Enrollee.Attestat as [Номер аттестата], Middle as [Средний балл аттестата], Phone as [Номер телефона], Birth as [Дата рождения], Money as [Есть возможность оплачивать?], Picture as [Фото абитуриента] from Attestat join (Passport join Enrollee on Passport.Passport = Enrollee.Passport) on Attestat.Attestat = Enrollee.Attestat", sqlConnect);
                        da.Fill(dt);
                        UniversalTable.DataSource = dt.Tables[0];
                    break;
                case 1:
                    try
                    {
                        da = new SqlDataAdapter($"Delete from EGE where EGE = {UniversalTable.Rows[UniversalTable.SelectedCells[0].RowIndex].Cells[0].Value}", sqlConnect);
                        da.Fill(dt);
                    }
                    catch
                    {
                        MessageBox.Show("Данная запись связана с другими таблицами! Удалите в других таблицах!");
                    }
                    da = new SqlDataAdapter("select EGE.EGE as [Номер аттестата ЕГЭ], Enrollee.Enrolle as [Номер абитуриента], Lessons as [Предметы которые сдавались], Score as [Общий балл за ЕГЭ] from (Attestat join (Passport join Enrollee on Passport.Passport = Enrollee.Passport) on Attestat.Attestat = Enrollee.Attestat) join EGE on Enrollee.Enrolle = EGE.Enrolle", sqlConnect);
                        da.Fill(dt);
                        UniversalTable.DataSource = dt.Tables[0];
                    break;
                case 2:
                    try
                    {
                        da = new SqlDataAdapter($"Delete from Contract where ContractID = {UniversalTable.Rows[UniversalTable.SelectedCells[0].RowIndex].Cells[0].Value}", sqlConnect);
                        da.Fill(dt);
                    }
                    catch
                    {
                        MessageBox.Show("Данная запись связана с другими таблицами! Удалите в других таблицах!");
                    }
                    da = new SqlDataAdapter("select ContractID as [Номер контракта], ContractAbout as [Условия договора], ContAdress as [Адрес предприятия], ContPhone as [Телефон предприятия], Payment as [Платят?] from Contract", sqlConnect);
                        da.Fill(dt);
                        UniversalTable.DataSource = dt.Tables[0];
                    break;
                case 3:
                    try
                    {
                        da = new SqlDataAdapter($"Delete from Commission where PersonID = {UniversalTable.Rows[UniversalTable.SelectedCells[0].RowIndex].Cells[0].Value}", sqlConnect);
                        da.Fill(dt);
                    }
                    catch
                    {
                        MessageBox.Show("Данная запись связана с другими таблицами! Удалите в других таблицах!");
                    }
                    da = new SqlDataAdapter("select PersonID as [Номер регистрации абитуриента], EGE as [Номер аттестата ЕГЭ], Faculty as [Факультет], Speciality as [Специальность], Registrar as [Фамилия принявшего документы], Talk as [Рекомендация для собеседования], ContractID as [Номер контракта], Result as [Набрано баллов при поступлении] from Commission", sqlConnect);
                    da.Fill(dt);
                        UniversalTable.DataSource = dt.Tables[0];
                    break;
                case 4:
                    try
                    {
                        da = new SqlDataAdapter($"Delete from Enrollment where YesID = {UniversalTable.Rows[UniversalTable.SelectedCells[0].RowIndex].Cells[0].Value}", sqlConnect);
                        da.Fill(dt);
                    }
                    catch
                    {
                        MessageBox.Show("Данная запись связана с другими таблицами! Удалите в других таблицах!");
                    }
                    da = new SqlDataAdapter("select YesID as [Номер после зачисления], PersonID as [Номер регистрации абитуриента], Type as [Основа, на которой зачислен] from Enrollment", sqlConnect);
                        da.Fill(dt);
                        UniversalTable.DataSource = dt.Tables[0];
                    break;
                case 5:
                    try
                    {
                        da = new SqlDataAdapter($"Delete from Users where Id = {UniversalTable.Rows[UniversalTable.SelectedCells[0].RowIndex].Cells[0].Value}", sqlConnect);
                        da.Fill(dt);
                    }
                    catch
                    {
                        MessageBox.Show("Данная запись связана с другими таблицами! Удалите в других таблицах!");
                    }
                    da = new SqlDataAdapter("select Id as [Номер пользователя], Login as [Логин], Password as [Пароль], Pravo as [Право доступа], Name as [Имя], LastName as [Фамилия], FrithName as [Отчество] from Users", sqlConnect);

                    da.Fill(dt);
                        UniversalTable.DataSource = dt.Tables[0];
                    break;
            }
        }
        //При нажатии на кнопку "Удалить запись"
        private void Delete_Click(object sender, EventArgs e)
        {
            //Вызов метода удаления
            del();
        }
        //Изменение записи таблицы
        private void Update_Click(object sender, EventArgs e)
        {
            switch (tabl)
            {
                //Номера таблиц
                case 0:
                    //Присваивание всех ячеек строки к массиву
                    t[14] = UniversalTable.Rows[UniversalTable.SelectedCells[0].RowIndex].Cells[0].Value.ToString();
                    t[0] = UniversalTable.Rows[UniversalTable.SelectedCells[0].RowIndex].Cells[1].Value.ToString();
                    t[1] = UniversalTable.Rows[UniversalTable.SelectedCells[0].RowIndex].Cells[2].Value.ToString();
                    t[2] = UniversalTable.Rows[UniversalTable.SelectedCells[0].RowIndex].Cells[3].Value.ToString();
                    t[3] = UniversalTable.Rows[UniversalTable.SelectedCells[0].RowIndex].Cells[4].Value.ToString();
                    t[4] = UniversalTable.Rows[UniversalTable.SelectedCells[0].RowIndex].Cells[5].Value.ToString();
                    t[5] = UniversalTable.Rows[UniversalTable.SelectedCells[0].RowIndex].Cells[6].Value.ToString();
                    t[6] = UniversalTable.Rows[UniversalTable.SelectedCells[0].RowIndex].Cells[7].Value.ToString();
                    t[7] = UniversalTable.Rows[UniversalTable.SelectedCells[0].RowIndex].Cells[8].Value.ToString();
                    t[8] = UniversalTable.Rows[UniversalTable.SelectedCells[0].RowIndex].Cells[9].Value.ToString();
                    t[9] = UniversalTable.Rows[UniversalTable.SelectedCells[0].RowIndex].Cells[10].Value.ToString();
                    t[10] = UniversalTable.Rows[UniversalTable.SelectedCells[0].RowIndex].Cells[11].Value.ToString();
                    t[11] = UniversalTable.Rows[UniversalTable.SelectedCells[0].RowIndex].Cells[12].Value.ToString();
                    t[12] = UniversalTable.Rows[UniversalTable.SelectedCells[0].RowIndex].Cells[13].Value.ToString();
                    t[13] = UniversalTable.Rows[UniversalTable.SelectedCells[0].RowIndex].Cells[14].Value.ToString();
                    break;
                case 1:
                    t[0] = UniversalTable.Rows[UniversalTable.SelectedCells[0].RowIndex].Cells[0].Value.ToString();
                    t[1] = UniversalTable.Rows[UniversalTable.SelectedCells[0].RowIndex].Cells[1].Value.ToString();
                    t[2] = UniversalTable.Rows[UniversalTable.SelectedCells[0].RowIndex].Cells[2].Value.ToString();
                    t[3] = UniversalTable.Rows[UniversalTable.SelectedCells[0].RowIndex].Cells[3].Value.ToString();
                    break;
                case 2:
                    t[0] = UniversalTable.Rows[UniversalTable.SelectedCells[0].RowIndex].Cells[0].Value.ToString();
                    t[1] = UniversalTable.Rows[UniversalTable.SelectedCells[0].RowIndex].Cells[1].Value.ToString();
                    t[2] = UniversalTable.Rows[UniversalTable.SelectedCells[0].RowIndex].Cells[2].Value.ToString();
                    t[3] = UniversalTable.Rows[UniversalTable.SelectedCells[0].RowIndex].Cells[3].Value.ToString();
                    t[4] = UniversalTable.Rows[UniversalTable.SelectedCells[0].RowIndex].Cells[4].Value.ToString();
                    break;
                case 3:
                    t[0] = UniversalTable.Rows[UniversalTable.SelectedCells[0].RowIndex].Cells[0].Value.ToString();
                    t[1] = UniversalTable.Rows[UniversalTable.SelectedCells[0].RowIndex].Cells[1].Value.ToString();
                    t[2] = UniversalTable.Rows[UniversalTable.SelectedCells[0].RowIndex].Cells[2].Value.ToString();
                    t[3] = UniversalTable.Rows[UniversalTable.SelectedCells[0].RowIndex].Cells[3].Value.ToString();
                    t[4] = UniversalTable.Rows[UniversalTable.SelectedCells[0].RowIndex].Cells[4].Value.ToString();
                    t[5] = UniversalTable.Rows[UniversalTable.SelectedCells[0].RowIndex].Cells[5].Value.ToString();
                    t[6] = UniversalTable.Rows[UniversalTable.SelectedCells[0].RowIndex].Cells[6].Value.ToString();
                    t[7] = UniversalTable.Rows[UniversalTable.SelectedCells[0].RowIndex].Cells[7].Value.ToString();
                    break;
                case 4:
                    t[14] = UniversalTable.Rows[UniversalTable.SelectedCells[0].RowIndex].Cells[0].Value.ToString();
                    t[0] = UniversalTable.Rows[UniversalTable.SelectedCells[0].RowIndex].Cells[1].Value.ToString();
                    t[1] = UniversalTable.Rows[UniversalTable.SelectedCells[0].RowIndex].Cells[2].Value.ToString();
                    t[2] = UniversalTable.Rows[UniversalTable.SelectedCells[0].RowIndex].Cells[3].Value.ToString();
                    t[3] = UniversalTable.Rows[UniversalTable.SelectedCells[0].RowIndex].Cells[4].Value.ToString();
                    t[4] = UniversalTable.Rows[UniversalTable.SelectedCells[0].RowIndex].Cells[5].Value.ToString();
                    t[5] = UniversalTable.Rows[UniversalTable.SelectedCells[0].RowIndex].Cells[6].Value.ToString();
                    t[6] = UniversalTable.Rows[UniversalTable.SelectedCells[0].RowIndex].Cells[7].Value.ToString();
                    t[7] = UniversalTable.Rows[UniversalTable.SelectedCells[0].RowIndex].Cells[8].Value.ToString();
                    t[8] = UniversalTable.Rows[UniversalTable.SelectedCells[0].RowIndex].Cells[9].Value.ToString();
                    t[9] = UniversalTable.Rows[UniversalTable.SelectedCells[0].RowIndex].Cells[10].Value.ToString();
                    t[10] = UniversalTable.Rows[UniversalTable.SelectedCells[0].RowIndex].Cells[11].Value.ToString();
                    t[11] = UniversalTable.Rows[UniversalTable.SelectedCells[0].RowIndex].Cells[12].Value.ToString();
                    t[12] = UniversalTable.Rows[UniversalTable.SelectedCells[0].RowIndex].Cells[13].Value.ToString();
                    t[13] = UniversalTable.Rows[UniversalTable.SelectedCells[0].RowIndex].Cells[14].Value.ToString();
                    break;
                case 5:
                    t[0] = UniversalTable.Rows[UniversalTable.SelectedCells[0].RowIndex].Cells[0].Value.ToString();
                    t[1] = UniversalTable.Rows[UniversalTable.SelectedCells[0].RowIndex].Cells[1].Value.ToString();
                    t[2] = UniversalTable.Rows[UniversalTable.SelectedCells[0].RowIndex].Cells[2].Value.ToString();
                    t[3] = UniversalTable.Rows[UniversalTable.SelectedCells[0].RowIndex].Cells[3].Value.ToString();
                    t[4] = UniversalTable.Rows[UniversalTable.SelectedCells[0].RowIndex].Cells[4].Value.ToString();
                    t[5] = UniversalTable.Rows[UniversalTable.SelectedCells[0].RowIndex].Cells[5].Value.ToString();
                    t[6] = UniversalTable.Rows[UniversalTable.SelectedCells[0].RowIndex].Cells[6].Value.ToString();
                    break;
            }
            //Переименование кнопки
            Create.Text = "Изменить";
            prost = 0;
            //Переход к методу "прокрутки"
            kryt(tabl, 0);
            //Переход к методу удаления
            del();
        }
        //Метод очищения переменных массива t
        public void ochishenie()
        {
            //Цикл для обнуления данных переменных массива
            for (int i = 0; i < t.Length; i++)
            {
                t[i] = "";
            }
        }
        //Метод разрешающий вводить только цифры
        public void cif(object sender, KeyPressEventArgs e)
        {
            //Если нажимаются символы от 0 до 9 или Enter или BackSpace, то они вводятся
            if (((e.KeyChar <= '9') && (e.KeyChar >= '0')) || (e.KeyChar == (char)Keys.Enter) || (e.KeyChar == (char)Keys.Back))
            {

            }
            //Если иной результат символ удаляется
            else e.KeyChar -= e.KeyChar;
        }
        //Фильтрация написания в textBox5
        private void TB5_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (tabl)
            {
                //Номера таблиц
                case 0:
                    switch (prost)
                    {
                        //Номера "прокрутки"
                        case 2:
                            //Метод разрешающий вводить только цифры
                            cif(sender, e);
                            break;
                        case 1:
                            cif(sender, e);
                            break;
                    }
                    break;
            }
        }
        //Фильтрация написания в textBox1
        private void TB1_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (tabl)
            {
                case 0:
                    switch (prost)
                    {
                        case 1:
                            cif(sender, e);
                            break;
                        
                    }
                    break;
                case 1:
                    switch (prost)
                    {
                        case 0:
                            cif(sender, e);
                            break;

                    }
                    break;
                case 2:
                    switch (prost)
                    {
                        case 0:
                            cif(sender, e);
                            break;

                    }
                    break;
            }
        }
        //Фильтрация написания в textBox4
        private void TB4_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (tabl)
            {
                case 0:
                    switch (prost)
                    {
                        case 1:
                            cif(sender, e);
                            break;
                    }
                    break;
                case 1:
                    switch (prost)
                    {
                        case 0:
                            cif(sender, e);
                            break;
                    }
                    break;
            }
        }
        //Фильтрация написания в textBox2
        private void TB2_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (tabl)
            {
                case 1:
                    switch (prost)
                    {
                        case 0:
                            cif(sender, e);
                            break;
                    }
                    break;
            }
        }
        //Присваивание номера к переменной
        private void PhoneNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Если открыта таблица "Абитуриент"
            if (tabl == 0)
            {
                //Присваивание к textBox'у значения находящегося в маске
                TB1.Text = PhoneNum.Text;
            }
            if (tabl == 2)
            {
                TB4.Text = PhoneNum.Text;
            }
        }
        //При выборе в comboBox'е
        private void YesNo_SelectedValueChanged(object sender, EventArgs e)
        {
            //Если таблица называется "Абитуриент"
            if (tabl == 0)
            {
                //Если выбранно "Да"
                if (YesNo.Text == "Да")
                {
                    //Присваивание результата к переменной
                    t[12] = "1";
                }
                if (YesNo.Text == "Нет")
                {
                    t[12] = "0";
                }
                if ((YesNo.Text == "Выберите")&&((YesNo.Text != "Нет") || (YesNo.Text != "Да")))
                {
                    t[12] = "";
                }
                TB3.Text = t[12];
            }
            if (tabl == 2)
            {
                if (YesNo.Text == "Да")
                {
                    t[4] = "1";
                }
                if (YesNo.Text == "Нет")
                {
                    t[4] = "0";
                }
                if ((YesNo.Text == "Выберите") && ((YesNo.Text != "Нет") || (YesNo.Text != "Да")))
                {
                    t[4] = "";
                }
            }
                if (tabl == 3)
                {
                    if (YesNo.Text == "Да")
                    {
                        t[5] = "1";
                    }
                    if (YesNo.Text == "Нет")
                    {
                        t[5] = "0";
                    }
                    if ((YesNo.Text == "Выберите") && ((YesNo.Text != "Нет") || (YesNo.Text != "Да")))
                    {
                        t[5] = "";
                    }
                
                
            }
        }
        //При выборе в comboBox'е
        private void MenuPrav_SelectedValueChanged(object sender, EventArgs e)
        {
            //Если таблица называется "Права доступа"
            if (tabl == 5)
            {
                //Если выбрано "Администратор"
                if (MenuPrav.SelectedIndex == 2)
                {
                    TB4.Text = "admin";
                    t[3] = "admin";
                }
                if (MenuPrav.SelectedIndex == 1)
                {
                    TB4.Text = "oper";
                    t[3] = "oper";
                }
                if (MenuPrav.SelectedIndex == 3)
                {
                    TB4.Text = "personal";
                    t[3] = "personal";
                }
                if ((MenuPrav.SelectedIndex != 2)&&(MenuPrav.SelectedIndex != 1)&&(MenuPrav.SelectedIndex != 3))
                {
                    TB4.Text = "user";
                    t[3] = "user";
                }
            }
        }
        //При выборе в comboBox'е
        private void MenuOsnov_SelectedValueChanged(object sender, EventArgs e)
        {
            //Если выбрано "Платно"
            if (MenuOsnov.SelectedIndex == 0)
            {
                //Присваивание переменной к результату
                t[2] = "0";
            }
            if (MenuOsnov.SelectedIndex == 1)
            {
                t[2] = "1";
            }
        }
        //При нажатии на кнопку "Создать запись"/"Изменить"
        private void Create_Click(object sender, EventArgs e)
        {
                textbox(tabl, prost);
                SqlConnection sqlConnect = new SqlConnection("Data Source=sql;Initial Catalog = уП_ ПМ01_Попов_СЕ_Приемная_комиссия_университета; Integrated Security = True");
                sqlConnect.Open();
                DataSet dt = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter();
                switch (tabl)
                {
                //Номера таблиц
                    case 0:
                        try
                        { 
                        //Запрос на добавление
                            da = new SqlDataAdapter($"INSERT INTO Passport  VALUES ('{t[5]}','{t[6]}','{t[7]}');", sqlConnect);
                            da.Fill(dt);
                        }
                        catch
                        {
                        //Оповещение при ошибке
                        MessageBox.Show("Номер паспорта не должен повторяться");
                        }
                        try
                        {
                        //Запрос на добавление
                        da = new SqlDataAdapter($"INSERT INTO Attestat  VALUES ('{t[8]}','{t[9]}');", sqlConnect);
                        da.Fill(dt);
                        //Запрос на добавление
                        da = new SqlDataAdapter($"INSERT INTO Enrollee (Name,LastName,FirthName,Date,Adress,Passport,Attestat,Phone,Birth,Money,Picture)  VALUES ('{t[0]}','{t[1]}','{t[2]}','{t[3]}','{t[4]}','{t[5]}','{t[8]}','{t[10]}','{t[11]}','{t[12]}','{t[13]}');", sqlConnect);
                            da.Fill(dt);
                        //Запрос на просмотр таблицы
                            da = new SqlDataAdapter("select Enrollee.Enrolle as [Номер абитуриента] ,Name as [Имя], LastName as [Фамилия], FirthName as [Отчество], Date as [Дата регистрации], Adress as [Адрес], Enrollee.Passport as [Номер паспорта], PassportDate as [Когда выдан паспорт], Region as [Кем выдан паспорт], Enrollee.Attestat as [Номер аттестата], Middle as [Средний балл аттестата], Phone as [Номер телефона], Birth as [Дата рождения], Money as [Есть возможность оплачивать?], Picture as [Фото абитуриента] from Attestat join (Passport join Enrollee on Passport.Passport = Enrollee.Passport) on Attestat.Attestat = Enrollee.Attestat", sqlConnect);
                            da.Fill(dt);
                        //Применение запроса на таблицу
                            UniversalTable.DataSource = dt.Tables[0];
                        //Переход к метду очищения
                            ochishenie();
                            t[3] = DateTime.Now.ToString();
                            t[6] = DateTime.Now.ToString();
                            t[11] = DateTime.Now.ToString();
                        }
                        catch
                        {
                            MessageBox.Show("Номер аттестата не должен повторяться");
                        }
                        break;
                    case 1:
                        try
                        {
                            da = new SqlDataAdapter($"INSERT INTO EGE (Enrolle, Lessons, Score)  VALUES ('{t[1]}','{t[2]}','{t[3]}');", sqlConnect);
                            da.Fill(dt);
                        }
                        catch
                        {
                            MessageBox.Show("Абитуриент с таким номером отсутствует");
                        }
                        da = new SqlDataAdapter("select EGE.EGE as [Номер аттестата ЕГЭ], Enrollee.Enrolle as [Номер абитуриента], Lessons as [Предметы которые сдавались], Score as [Общий балл за ЕГЭ] from (Attestat join (Passport join Enrollee on Passport.Passport = Enrollee.Passport) on Attestat.Attestat = Enrollee.Attestat) join EGE on Enrollee.Enrolle = EGE.Enrolle", sqlConnect);
                        da.Fill(dt);
                        UniversalTable.DataSource = dt.Tables[0];
                        ochishenie();
                        break;
                    case 2:

                        da = new SqlDataAdapter($"INSERT INTO Contract (ContractAbout, ContAdress,ContPhone,Payment)  VALUES ('{t[1]}','{t[2]}','{t[3]}','{t[4]}');", sqlConnect);
                        da.Fill(dt);
                        da = new SqlDataAdapter("select ContractID as [Номер контракта], ContractAbout as [Условия договора], ContAdress as [Адрес предприятия], ContPhone as [Телефон предприятия], Payment as [Платят?] from Contract", sqlConnect);
                        da.Fill(dt);
                        UniversalTable.DataSource = dt.Tables[0];
                        ochishenie();
                        break;
                    case 3:
                        try
                        {
                            da = new SqlDataAdapter($"INSERT INTO Commission (EGE, Faculty, Speciality, Registrar, Talk, ContractID,Result)  VALUES ('{t[1]}','{t[2]}','{t[3]}','{t[4]}','{t[5]}','{t[6]}','{t[7]}');", sqlConnect);
                            da.Fill(dt);
                        }
                        catch
                        {
                            MessageBox.Show("Такой Номер контракта/Номер аттестата ЕГЭ отсутствует");
                        }
                        da = new SqlDataAdapter("select PersonID as [Номер регистрации абитуриента], EGE as [Номер аттестата ЕГЭ], Faculty as [Факультет], Speciality as [Специальность], Registrar as [Фамилия принявшего документы], Talk as [Рекомендация для собеседования], ContractID as [Номер контракта], Result as [Набрано баллов при поступлении] from Commission", sqlConnect);
                        da.Fill(dt);
                        UniversalTable.DataSource = dt.Tables[0];
                        ochishenie();
                        break;
                    case 4:
                        try
                        {
                            da = new SqlDataAdapter($"INSERT INTO Enrollment (PersonID, Type)  VALUES ('{t[1]}','{t[2]}');", sqlConnect);
                            da.Fill(dt);
                        }
                        catch
                        {
                            MessageBox.Show("Такой Номер регистрации абитуриента отсутствует");
                        }
                        da = new SqlDataAdapter("select YesID as [Номер после зачисления], PersonID as [Номер регистрации абитуриента], Type as [Основа, на которой зачислен] from Enrollment", sqlConnect);
                        da.Fill(dt);
                        UniversalTable.DataSource = dt.Tables[0];
                        ochishenie();
                        break;
                    case 5:

                        da = new SqlDataAdapter($"INSERT INTO Users(Login,Password,Pravo,Name,LastName,FrithName)  VALUES ('{t[1]}','{t[2]}','{t[3]}','{t[4]}','{t[5]}','{t[6]}');", sqlConnect);
                        da.Fill(dt);
                        da = new SqlDataAdapter("select Id as [Номер пользователя], Login as [Логин], Password as [Пароль], Pravo as [Право доступа], Name as [Имя], LastName as [Фамилия], FrithName as [Отчество] from Users", sqlConnect);
                        da.Fill(dt);
                        UniversalTable.DataSource = dt.Tables[0];
                        ochishenie();
                        break;
            }
            //Если на кнопке написано "Изменить"
            if (Create.Text == "Изменить")
            {
                //Переименовать кнопку на "Создать запись"
                Create.Text = "Создать запись";
            }
            prost = 0;
            //Применение метода "прокрутки"
            kryt(tabl, prost);
        }
        //При выборе любой ячейки в таблице
        private void UniversalTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //При выборе любой ячейки в таблице "Абитуриент"
            if (tabl == 0)
            {
                try
                {
                    //Переменная считывающая путь указанный в базе данных
                    pic = UniversalTable.Rows[UniversalTable.SelectedCells[0].RowIndex].Cells[14].Value.ToString();
                    //Применение пути к pictureBox'у 
                    PhotoAbPicture.Image = Image.FromFile(pic);
                    //Если изображение присутствует
                    if (PhotoAbPicture.Image != null)
                    {
                        Size = new Size(854, 446);
                        PhotoAbPicture.Visible = true;
                        label6.Visible = true;
                    }
                    //Если иной результат
                    else
                    {
                        Size = new Size(635, 446);
                        PhotoAbPicture.Visible = false;
                        label6.Visible = false;
                    }
                }
                catch
                {
                }
            }
        }
        //При нажатии на кнопку "Выбрать" на таблице "Абитуриенты"
        private void PhotoAb_Click(object sender, EventArgs e)
        {
            //Если выбран файл
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //Имя выбранного файла переходит в переменную
                TB4.Text = openFileDialog1.FileName;
                t[13] = openFileDialog1.FileName;
            }
        }
        //При нажатии на кнопку с стрелкой вправо
        private void ArrowRight_Click(object sender, EventArgs e)
        {
            textbox(tabl, prost);
            kryt(tabl, prost);
            prost++;
            kryt(tabl, prost);
        }
    }
}
