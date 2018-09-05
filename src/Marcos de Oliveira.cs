using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Person1
{
    public class Person
    {
        public string name;
        public string id;
        public string ID {get{return this.id;}
        set{
            if (this.ValidarID(value)==false){
                this.id = "";
            }
            else
            {
                this.id = value;
            }
        }
        }
        public Person(string name, string ID){
            this.name = name;
            this.ID = ID;
        }
        public void IntroduceYourself(){
            Console.WriteLine(this.name + " " + this.ID);
        }
        
        public bool ValidarID(string cedula){
            string numb = "2987634";
            int result = Convert.ToInt32(cedula[10].ToString());
            string th = cedula.Remove(9);
            th = cedula[0].ToString() + cedula[2].ToString() + cedula[3].ToString() + cedula[4].ToString()
            + cedula[6].ToString() + cedula[7].ToString() + cedula[8].ToString();
            string result1 = "";
            string result2 = "";
            for (int i=0; i<=6; i++){
                int n1 = Convert.ToInt32(numb[i].ToString());
                int n2 = Convert.ToInt32(th[i].ToString());
                float flotante = (float)(n1*n2);
                result2 = (flotante/10).ToString();
                result1 = result1 + result2[result2.Length-1].ToString();
            }
            int result3 = 0;
            for (int i=0; i<=6; i++){
                result3 = result3 + Convert.ToInt32(result1[i].ToString());
            }
            if (result3>20 & result3<=29){
                result3 = 30-result3;
            }
            if (result3>30 & result3<=39){
                result3 = 40-result3;
            }
            if (result3>40 & result3<=49){
                result3 = 50-result3;
            }
            return result3 == result;

        }
        static void Main(string[] args)
        {
            Person john = new Person("John Doe", "1.234.567-9");
            Person jane = new Person("Jane Doe", "8.765.432-7");
            john.IntroduceYourself();
            jane.IntroduceYourself();
            Console.WriteLine(john.ID);
        }
    }
}
