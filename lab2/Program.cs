using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization.Json;
using System.Runtime.Serialization;


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
        public List<Member> Members { get; set; }
        [DataMember]
        public int MemberNumber { get; set; }
        [DataMember]
        public int Weight { get; set; }
        [DataMember]
        public int Year;
        [DataMember]
        public string DateService;
        [DataMember]
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
            return this.ID +"\n"+  this.Type + "\n" + this.Model + "\n" + this.Members + "\n" + this.MemberNumber + "\n" +  this.Weight + "\n" + this.Year + "\n" + this.DateService;
        }
    }




}
