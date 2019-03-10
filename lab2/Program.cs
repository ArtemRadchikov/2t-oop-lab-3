using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization.Json;
using System.Runtime.Serialization;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace lab2
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }

    [DataContract]
    public class Owner
    {
        public Owner(string name, string contry, int year, string[] types)
        {
            Name = name;
            Contry = contry;
            Year = year;
            Types = types;
        }
        public Owner() { }
        [DataMember]
        [Required]
        [OwnerName]
        public string Name { get; set;}
        [DataMember]
        public string Contry { get; set; }
        [DataMember]
        public int Year { get; set; }
        [DataMember]
        public string[] Types { get; set; }
        
    }

    [DataContract]
    public class Member
    {
        public Member(string fio, string prof, int age, int exp)
        {
            this.Age = age;
            this.Exp = exp;
            this.Fio = fio;
            this.Prof = prof;
        }

        public Member() { }
        [DataMember]
        [StringLength(50,MinimumLength =10,ErrorMessage ="Недопустимая длинна ФИО")]
        public string Fio { get; set; }
        [DataMember]
        public string Prof { get; set; }
        [DataMember]
        public int Age { get; set; }
        [DataMember]
        public int Exp { get; set; }
    }

    public static class AircraftMembers
    {
        public static List<Member> members = new List<Member>();
        public static bool IsOk;
        public static Owner form3Owner;

        public static List<Aircraft> aircrafts;
        
        static AircraftMembers()
        {
            aircrafts = new List<Aircraft>();
        }
    }

    [DataContract]
    public class Aircraft
    {
        [DataMember]
        public string ID { get; set; }
        [DataMember]
        public string Type { get; set; }
        [DataMember]
        public string Model { get; set; }
        [DataMember]
        [Required(ErrorMessage ="Отсутствует экипаж")]
        public List<Member> Members { get; set; }
        [DataMember]
        public int MemberNumber { get; set; }
        [DataMember]
        public int Weight { get; set; }
        [DataMember]
        [Required]
        [Range(2003,2019,ErrorMessage ="Возраст самолёта должен быть от 2003 до 2019")]
        public int Year;
        [DataMember]
        public string DateService;
        [DataMember]
        [Required(ErrorMessage ="Отсутсвует производитель")]
        public Owner ThisOwner { get; set; }
        public Aircraft() { }

        public Aircraft(string iD, string type, string model, List<Member> members, int memberNumber, int weight, int year, string dateService,Owner owner)
        {
            this.ID = iD;
            this.Type = type;
            this.Model = model;
            this.Members = members;
            this.MemberNumber = memberNumber;
            this.Weight = weight;
            this.Year = year;
            this.DateService = dateService;
            this.ThisOwner = owner;
        }

        public override string ToString()
        { 
            return "Авиокомпания: " + ThisOwner.Name +" | " + " тип: "+this.Type+" | кол-во мест: "+this.MemberNumber+" | грузоподъемность: "+this.Weight +" \r\n";
        }

        
    }
    public class OwnerNameAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {            
            if (value != null)
            {
                string[] collection = {"Aerospatiale/Alenia","Airbus S.A.S.", "Bell/Agusta Aerospace Company","Boeing","Bombardier Aerospace","British Aerospace","British Aircraft Corporation","Britten-Norman","Cessna Aircraft","Czech Aircraft Works",
                                       "Dassault Aviation","De Havilland","De Havilland Canada","EADS Socata","Embraer (Empresa Brasileira de Aeronautica) S.A.","Fairchild-Dornier","Fokker","GROB Aerospace","Gulf Aircraft Partnership (GAP)",
                                       "Gulfstream Aerospace Corporation","Harbin Aircraft Manufacturing Corporation","Israel Aircraft","Kestrel Aircraft","Lancair","Let Aircraft Industries","Lockheed Corporation","McDonnell Douglas","Saab",
                                       "Vickers","Xi'an Aircraft Industrial Corporation","Англо-французский консорциум BAC-SNIAS","Гражданские самолеты Сухого","МышМашАвиа","Нижегородский авиационный завод","ОКБ А.Н.Туполева",
                                       "ОКБ А.С. Яковлева","ОКБ Г.М. Бериева","ОКБ О.К.Антонова","ОКБ С.В. Ильюшина"};
                string Name = value.ToString();

                if (collection.Contains(Name))
                    return true;
                else
                    this.ErrorMessage = "Введите одно из доступных значений";
            }

            return false;
        }
    }
}
