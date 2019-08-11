using System;
using System.Net;
using System.Net.Http;


namespace EmployeeData
{
    public class EmployeeClass
    {
        public string EmployeeData(string URL)
        {
            using (var httpclient = new HttpClient())
            {
                var res = httpclient.GetStringAsync(new Uri(URL)).Result;
                return res;

            }
        }
    }
}
