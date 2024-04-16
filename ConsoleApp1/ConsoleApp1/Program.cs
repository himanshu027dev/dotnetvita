// See https://aka.ms/new-console-template for more information

// accept 5 ele in arr and display data in sorted order
//accept 5 name from user and reverse the element of array
//accept 3 ele and copy it into another array
//accept 5 ele in arr 1and copy from 1st index all the data  to another array
// acc 5 ele write a method and pass array to it this meth will store square of each element in entry point print the array
//find out whivh algo they are using
//create a class student with  member variable id,name,perecentage.create 5 array of the student &store 5 record
//create array of account class and store 5 object
using System;
namespace randombs
{   /*class student
    {
        int stuid;
        string name;
        float percentage;

        public student(int studid,string  name,float percentage)
        {
            this.stuid = stuid;
            this.name = name;
            this.percentage = percentage;
        }
        public string showing()
        {
            return "stuid" + stuid + " " + "name " + name + " percentage " + percentage;
        }

    }*/
    class arraybs
    {
       public static void Main()
        {/*
            try
            {
                account a1 = new account("himanshu",1000);
               
                a1.deposit(1000);
                a1.withdraw(100);
                Console.WriteLine(a1.intmoney());
                Console.WriteLine(a1.display(a1));

            }
            catch(Exception c) 
            {
                Console.WriteLine(c.Message);
            }*/
/*
            student[] s1 = new student[5];
            s1[0] = new student(1, "holla", 97.3f);*/



            /*try {
                employee e1 = new employee("himanshu", 49000);
                e1.show();
                
                Console.WriteLine(e1.lunchmoney());
                Console.WriteLine(e1.show());
            }
            catch(Exception e){
                Console.WriteLine(e.Message);
            }
            try
            {
                employee e2 = new employee("lowx", 40000);
                e2.show();
                Console.WriteLine(e2.lunchmoney());
                Console.WriteLine(e2.show());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            try
            {
                employee e3 = new employee("david", 500000);
                e3.show();
                Console.WriteLine(e3.lunchmoney());
                Console.WriteLine(e3.show());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            try
            {
                employee e4 = new employee("holla", 30000);
                e4.show();
                Console.WriteLine(e4.lunchmoney());
                Console.WriteLine(e4.show());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            try
            {
                employee e5 = new employee("ollaamigos", 30000);
                e5.show();
                Console.WriteLine(e5.lunchmoney());
                Console.WriteLine(e5.show());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }*/


           
            int[] arr = new int[5];
            int[] cpyarr = new int[arr.Length+1];
            for(int i = 0;i < arr.Length;i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            Array.Sort(arr);
            for(int k=0;k<arr.Length;k++)
            {
                Console.WriteLine(arr[k]);
            }
            for(int j = 0; j <arr.Length; j++)
            { int temp;
                 temp= arr[j];
                arr[j] = arr[arr.Length - j-1];
                arr[arr.Length- j-1] = temp;
            }
            for (int k = 0; k < arr.Length; k++)
            {
                Console.WriteLine(arr[k]);
            }
            Array.Reverse(arr);
            arr.CopyTo(cpyarr, 1);
            for(int g= 0;g < cpyarr.Length;g++)
            {
                Console.WriteLine(cpyarr[g]);
            }

            // create a class with method swap that swap the value and print value in entry point 
            // accept a number from user and pass it to method this method will return all the factor of that number
        }
        
    }

    class employee
    {
        static int getid;
        int id;
        string _name;
        double _salary;
        double net_salary;
        static double TDS = 10;
         static employee()
        {
            Console.WriteLine("dhanki company");
        }
        public employee(string name, double salary)
        {
            Name = name;
            Salary = salary;

            id = ++getid;
            if (id > 3)
            {
                throw new Exception("naa a aa n0");
            }

        }

        string Name{ 
            
            get{
            return _name;
            }
            set
            {
                _name = value;
            }
                }
        double Salary
        {
            get
            {
                return _salary;
            }
            set
            {
                if (value > 50000)
                {
                    throw new Exception("ERRR");
                }
                else
                {
                    _salary = value;
                }
            }

        }
            public double lunchmoney(){ 
            double tax = _salary * TDS / 100;
            net_salary = _salary - tax;
            return tax;
            }
            
            public int retid()
        {
            return id;
        }
        public string show()
        {
            return string.Format("id= {0} name={1} salary={2} net_salary={3}",id,_name,_salary,net_salary);
        }

        

    }
    
    class account
    {
        static int getid;
        int id;
        string _aname;
        double _balance;
        static double Interestrate = 0.07;
        const double minbal = 1000;
        double total_balance;
        public account(string name,double balance)
        {
           Name=name;
            Balance= balance;
            id = ++getid;
        }
        
        string Name
    {
             get
            {
            return _aname;
            }
            set
            {
                _aname = value;
            }
    }
        
        double Balance
        {
            get
            {
                return _balance;
            }
            set
            {
                if (value < minbal)
                {
                    throw new Exception("NOT BLOODY LIKELY");
                }
                else
                {
                    _balance = value;
                }
            }
        }

        public void deposit(int money)
        {
            if (money < 0)
            {
                Console.WriteLine("yeah! now bring money and some celcius");
            }else{
                _balance = _balance + money; }
        }
        public void withdraw(int bigmoney)
        {
            if (_balance < bigmoney)
            {
                Console.WriteLine("first bring some money");
            }
            else
            {
                _balance = _balance - bigmoney;
            }
        }
        public double intmoney()
        {
            double income = _balance * Interestrate;
            total_balance = Balance + income;
            return income;

        }
        public string display(account re)
        {
            return string.Format("id={0} name={1} balance={2} balance_after_int={3}",id,_aname,_balance,total_balance);      
        }


    }




}

