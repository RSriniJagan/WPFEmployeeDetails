using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.IO;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPFEmployeeDetails
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Employeedetails objemployeedetails = new Employeedetails();
            objemployeedetails.EmployeeName = txtboxempname.Text;
            objemployeedetails.EmpId = txtboxempid.Text;
            objemployeedetails.Emailid = txtemailid.Text;
            objemployeedetails.Gender = txtgender.Text;
            objemployeedetails.Status = txtStatus.Text;
            string json = JsonConvert.SerializeObject(objemployeedetails);
            var baseAddress = "https://gorest.co.in/public-api/users?name=" + txtboxempname.Text + "&id=" + txtboxempid.Text + "&email=" + txtemailid.Text + "&gender=" + txtgender.Text + "&status = " + txtStatus.Text + "";
            var http = (HttpWebRequest)WebRequest.Create(new Uri(baseAddress));
            http.Accept = "application/json";
            http.ContentType = "application/json";
            http.Method = "POST";
            string parsedContent = json;
            ASCIIEncoding encoding = new ASCIIEncoding();
            Byte[] bytes = encoding.GetBytes(parsedContent);
            Stream newStream = http.GetRequestStream();
            newStream.Write(bytes, 0, bytes.Length);
            newStream.Close();
            var response = http.GetResponse();
            var stream = response.GetResponseStream();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Employeedetails objemployeedetails = new Employeedetails();
            objemployeedetails.EmployeeName = txtboxempname.Text;
            objemployeedetails.EmpId = txtboxempid.Text;
            objemployeedetails.Emailid = txtemailid.Text;
            objemployeedetails.Gender = txtgender.Text;
            objemployeedetails.Status = txtStatus.Text;
            //objProduct.Mobile = txtMobile.Text;
            string json = JsonConvert.SerializeObject(objemployeedetails);
            var baseAddress = "https://gorest.co.in/public-api/users?name=" + txtboxempname.Text + "&id=" + txtboxempid.Text + "&email=" + txtemailid.Text + "&gender=" + txtgender.Text + "&status = " + txtStatus.Text + "";
            var http = (HttpWebRequest)WebRequest.Create(new Uri(baseAddress));
            http.Accept = "application/json";
            http.ContentType = "application/json";
            http.Method = "PUT";
            string parsedContent = json;
            ASCIIEncoding encoding = new ASCIIEncoding();
            Byte[] bytes = encoding.GetBytes(parsedContent);
            Stream newStream = http.GetRequestStream();
            newStream.Write(bytes, 0, bytes.Length);
            newStream.Close();
            var response = http.GetResponse();
            var stream = response.GetResponseStream();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Employeedetails objemployeedetails = new Employeedetails();
            objemployeedetails.EmployeeName = txtboxempname.Text;
            objemployeedetails.EmpId = txtboxempid.Text;
            objemployeedetails.Emailid = txtemailid.Text;
            objemployeedetails.Gender = txtgender.Text;
            objemployeedetails.Status = txtStatus.Text;
            //objProduct.Mobile = txtMobile.Text;
            string json = JsonConvert.SerializeObject(objemployeedetails);
            var baseAddress = "https://gorest.co.in/public-api/users?empid=" + txtboxempid.Text + "";
            var http = (HttpWebRequest)WebRequest.Create(new Uri(baseAddress));
            http.Accept = "application/json";
            http.ContentType = "application/json";
            http.Method = "DELETE";
            string parsedContent = json;
            ASCIIEncoding encoding = new ASCIIEncoding();
            Byte[] bytes = encoding.GetBytes(parsedContent);
            Stream newStream = http.GetRequestStream();
            newStream.Write(bytes, 0, bytes.Length);
            newStream.Close();
            var response = http.GetResponse();
            var stream = response.GetResponseStream();
        }
    }
}
