using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.SimkinOA.Sprint6.Task6.V23.Lib
{
    public class DataService : ISprint6Task6V23
    {
        public string CollectTextFromFile(string path)
        {
            string resStr = "";
            using (StreamReader sr = new StreamReader(path))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] fun = line.Split(" ");
                    foreach (string s in fun)
                    {
                        if (s.Contains("s"))
                        {
                            resStr += s;
                        }
                    }
                }
                return resStr;
            }
        }
    }
}