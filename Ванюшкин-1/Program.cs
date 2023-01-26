using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Ванюшкин_1
{
    internal class Program
    {
        class User
        {
            public string name;
            public string login;
            public string password;
            public User(string name, string password, string login) { }
            public bool enter(string login, string password)
            {
                return true;
            }
            public string getName()
            {
                return name;
            }
        }
        class Admin : User
        {
            public Admin(string name, string password, string login) : base(name, password, login)
            {
            }
        }
        class Professor : User
        {
            public Professor(string name, string password, string login) : base(name, password, login)
            {
            }
        }
        class Request
        {
            public Professor requester;
            public string discipline;
            public int group;
            public int pairslnWeek;
            public Request(Professor requester, string disc, int group, int hours)
            {
                
            }
            public Professor getRequester()
            { return requester; }
            public string getDiscipline() { return discipline; }
            public int getGroup() { return group; }
            public int getPairs() { return pairslnWeek; }
        }
        class TimetableSystem
        {
            public List<string> users;
            public List<string> requests;
            public User currentUser;
            public int countOfRooms;
            public int pairslnDay;
            static void Main(string[] args)
            {
                Console.ReadKey();
            }
            public void addUser(string name, string password, string login, string repeation, int type) { }
            public User findUser(string login, string password) { return currentUser; }
            public void save()
            {

            }
            public void load() { }
            public void addRequest(string disc, int group, int pairs) { }
            public void processRequest() { }

        }

        
    }
}
