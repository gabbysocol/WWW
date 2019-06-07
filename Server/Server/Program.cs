using System;
using System.Text;
using System.ServiceModel;
using System.Collections.Generic;
using System.ServiceModel.Channels;
using System.Threading;
using SERVER;

namespace Server
{
    public class SERVER         //Server
    {
        [ServiceContract]
        public interface IMyService
        {
            [OperationContract]
            int[] SendLevel(int level, string time);

            [OperationContract]
            string SendResult(string str, string uri, int score);

            [OperationContract]
            string SendAllResult();
        }

        public class MyService : IMyService
        {
            static int NumberOfUsers = 0;
            static List<string> WonUsers = new List<string>();
            public static Queue<string> UriUsers = new Queue<string>();

            //Good
            public int[] SendLevel(int level, string uri)
            {
                ++NumberOfUsers;
                Console.WriteLine("I get level - " + level);
                var sudoku = new SudokuGame();
                var arr = new int[81];
                for (var i = 0; i < 9; ++i)
                {
                    for (var j = 0; j < 9; ++j)
                    {
                        arr[i * 9 + j] = sudoku.Numbers[i, j];
                    }
                }
                return arr;
            }

            public string SendResult(string str, string time, int score)
            {
                WonUsers.Add("User :" + str + " time " + time + "  score - " + score);
                var resStr = String.Join("\n", WonUsers.ToArray());
                return resStr;
            }

            public string SendAllResult()
            {
                WonUsers.Add("");
                var resStr = String.Join("\n", WonUsers.ToArray());
                return resStr;
            }
        }

        class Program
        {
            static void Main(string[] args)
            {
                ServiceHost host = new ServiceHost(typeof(MyService), new Uri("http://localhost:8001/MyService"));
                host.AddServiceEndpoint(typeof(IMyService), new BasicHttpBinding(), "");
                host.Open();
                Console.WriteLine("Server Ready");
  
                Console.ReadKey(true);
            }
        }
    }
}