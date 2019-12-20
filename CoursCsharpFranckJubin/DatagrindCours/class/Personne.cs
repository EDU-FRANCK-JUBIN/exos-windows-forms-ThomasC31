using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatagrindCours
{
class personne
{
    public string name { get; set; }
    public string surname { get; set; }
    public DateTime birthdate { get; set; }
    public int age { get; set; }
    public personne()
    {

    }
    public personne(string name)
    {
        this.name = name;
    }
    public personne(string name, string surname, DateTime birthdate, int age)
    {
        this.name = name;
        this.surname = surname;
        this.birthdate = birthdate;
        this.age = age;

    }
}
}
