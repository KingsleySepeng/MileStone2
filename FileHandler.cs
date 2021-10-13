using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace MileStone2
{
    class FileHandler
    {
        string path = @"C:\Users\ester\Dropbox\My PC (LAPTOP-PP6RURFJ)\Documents\2021 BC\PRG282\Users.txt";
        List<string> allLines = new List<string>();

        public bool getUsers(string name, string password)
        {
            bool found = false;
            allLines = File.ReadAllLines(path).ToList();
            foreach (string line in allLines)
            {
                string[] items = line.Split(',');
                if (items[0] == name && items[1] == password)
                {
                    found = true;
                }
            }
            return found;
        }

        public void addUser(string name, string password)
        {
            FileStream myStream = new FileStream(path, FileMode.Append);
            StreamWriter writer = new StreamWriter(myStream);
            writer.WriteLine(name + "," + password);
            writer.Close();
            myStream.Close();
        }

        public bool ifExist(string username, string password)
        {
            bool exists = false;
            allLines = File.ReadAllLines(path).ToList();
            foreach (string line in allLines)
            {
                string[] items = line.Split(',');
                if (items[0] == username)
                {
                    exists = true;
                }
            }
            return exists;
        }
    }
}
