using System;
using System.Data;

namespace ExtensaoDeClasses
{
    public static class MyExtensions
    {
        public static void EscrevendoJSON(this DataSet dataSet, string nomeArquivo)
        {
             
        }

        public static string toUrl(this string stringUrl)
        {
            return stringUrl = "http://" + stringUrl;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //var dataSet = new DataSet();
            //dataSet.WriteXml("dados.xml");
            //dataSet.EscrevendoJSON("dados.js");
            //dataSet.WriteXml("dados.xml");
            var url = "google.com";
            Console.WriteLine(url.toUrl());
            Console.ReadLine();
        }
    }
}
