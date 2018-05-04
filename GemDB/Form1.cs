using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bogus;
namespace GemDB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            rnd = new Random();
            Testing();
        }
        private static Random rnd;
        private void Testing1()
        {
            var lorem = new Bogus.DataSets.Name().FullName();
        }
        string result = "";
      
        private void Testing()
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();

           
           
            var threadA = new Thread(D);
            var threadB = new Thread(D);
            var threadC = new Thread(D);
            var threadD = new Thread(D);
            var threadE = new Thread(D);
            var threadF = new Thread(D);
            var threadG = new Thread(D);
            var threadH = new Thread(D);
            var threadI = new Thread(D);
            var threadJ = new Thread(D);

            threadA.Start();
            threadB.Start();
            threadC.Start();
            threadD.Start();
            threadE.Start();
            threadF.Start();
            threadG.Start();
            threadH.Start();
            threadI.Start();
            threadJ.Start();

            threadA.Join();
            threadB.Join();
            threadC.Join();
            threadD.Join();
            threadE.Join();
            threadF.Join();
            threadG.Join();
            threadH.Join();
            threadI.Join();
            threadJ.Join();


            //var threadA = new Thread(() =>{result=A(result);});
            //var threadB = new Thread(() => { result = B(result); });
            //threadA.Start();
            //threadB.Start();
            //threadA.Join();
            //threadB.Join();

            sw.Stop();


             var test = sw.ElapsedMilliseconds;

        }

        //private void B()
        //{
        //    string value = string.Empty;
        //    for (int i = 0; i <= 10000; i++)
        //    {
        //        var name = new Bogus.DataSets.Name().FirstName().Replace("'","");
        //        var FirstName = name.Length>10?name.Substring(0,9):name;
        //        var FullName = new Bogus.DataSets.Name().FullName().Replace("'","");
        //        value += "Insert into nvarchar(Nvarchar10,Nvarchar30,Nvarchar50,Nvarchar80,Nvarchar100,Nvarchar150,Nvarchar200,Nvarchar250,Nvarchar300,Nvarchar350,Nvarchar400,Nvarchar450,Nvarchar500,Type) Values " +
        //            "('" + FirstName + "','" + FullName + "','" + FullName + "','" + FullName + "','" + FullName + "','" + FullName + "','" + FullName + "','" + FullName + "','" + FullName + "','" + FullName + "','" + FullName + "','" + FullName + "','" + FullName + "','Name')"+Environment.NewLine;
        //    }
        //    result = result + value;  
        //}

        private void B()
        {
            string value = string.Empty;
            for (int i = 0; i <= 10000; i++)
            {
               
                int Tinyint = rnd.Next(0,255);
               
                Int64 temp1 = rnd.Next(0,999999999);
              
                Int64 temp2 = rnd.Next(0,9999999);
                long Bigint = temp1 * temp2;
               
                int smallint = rnd.Next(0,32767);
               
                Int32 temp3 = rnd.Next(0,99999);
              
                Int32 temp4 = rnd.Next(0,99999);
                Int32 Int = temp3 * temp4;
                value += "Insert into Int(Tinyint,Bigint,Int,Smallint) Values " +
                    "(" + Tinyint + "," + Bigint + "," + Int + "," + smallint + ")" + Environment.NewLine;
            }
            result = result + value;
        }

        private void C()
        {
            string value = string.Empty;
            for (int i = 0; i <= 10000; i++)
            {
               
                int Tinyint =rnd.Next(0, 999);
                Decimal d3_2 = (Decimal)Tinyint / 100;

               
                Int64 temp1 = rnd.Next(0, 99999);
                Decimal d5_2 = (Decimal)temp1 / 100;
               
                Int64 temp2 = rnd.Next(0, 999);
                long Bigint = temp1 * temp2;
                Decimal d8_2 = (Decimal)Bigint / 100;
                
                Int32 smallint = rnd.Next(0, 999);
                temp1 = rnd.Next(0, 99999);
                long temp12 = temp1 * smallint;
                Decimal d10_2 = (Decimal)temp12 / 100;
               
                Int32 temp3 = rnd.Next(0, 99999);
                temp1 = rnd.Next(0, 999999);
                long temp15 = temp1 * smallint;
                Decimal d15_2 = (Decimal)temp15 / 100;
     
                value += "Insert into Decimal(Dec3_2,Dec5_2,Dec8_2,Dec10_2,Dec15_2) Values " +
                    "(" + d3_2 + "," + d5_2 + "," + d8_2 + "," + d10_2+ "," + d15_2 + ")" + Environment.NewLine;
            }
            result = result + value;
        }

        //private void D()
        //{
        //    string value = string.Empty;
        //    for (int i = 0; i <= 10000; i++)
        //    {
        //        DateTime dt = DateTime.Now;
        //        int ti= 0;
        //        if (dt.Millisecond % 2 == 0)
        //            ti = 0;
        //        else
        //            ti = 1;
                
        //        value += "Insert into General(Bit) Values " +
        //            "(" + ti + ")" + Environment.NewLine;
        //    }
        //    result = result + value;
        //}

    }
}
