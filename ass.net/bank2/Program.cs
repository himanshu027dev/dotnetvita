using System;
using System.Globalization;

namespace endofallaccount{
    class account{

        static account(){
            Console.WriteLine("run! bitch! run!\n @or you will lose all savings");
        }
        static int p=0;
        private string name;
        private int id;
        private double balance;
        static double intrate=0.07;
        public double bal_after;

        
        public account(string n,double b){
            accname=n;
            accid=++p;
            accbalance=b;
        }

        public string accname{
            get{ return name;}
            set{ name=value;}
        }
        public int accid{
            get{ return id;}
            set{ id=value;}
        }
        public double accbalance{
            get{ return balance;}
            protected set{ balance=value;}
        }


        public void deposit(int amt){
            balance=balance+amt;
        }

        virtual public void withdraw(int amt){
            balance=balance-amt;
        }
        public double payint(account re){
            double income=re.balance*intrate;
            re.bal_after=re.balance+income;
            return income;
        }

    }
    class currentaccount : account{
        string s;
        public currentaccount(string name,double balance,string k):base(name,balance){
                
                s=k;
        }
        public override string ToString(){
            return "account name: "+accname+"\naccount id: "+accid+"\naccount balance: "+accbalance+"\nTYPE OF ACCOUNT"+s;
        }
        public void show(){
            double r=payint(this);
            Console.WriteLine("balance after interest ="+bal_after);
            
        }



        
    }
    class savingaccount : account{
        string s;
        const int minbal=1000;
        public savingaccount(string name,double balance,string k):base(name,balance){
                
                if(balance<minbal){
                       throw new Exception("err"); 
                }else{
                s=k;}
        }
        

        public void withdraw(int amt){
            if(accbalance-minbal<amt){
                throw new Exception("err");
            }
            else{
                accbalance=accbalance-amt;
            }
        }
        public override string ToString(){
            return "account name: "+accname+"\naccount id: "+accid+"\naccount balance: "+accbalance+"\nTYPE OF ACCOUNT"+s;
        }
        public void show(){
            double r=payint(this);
            Console.WriteLine("balance after interest ="+bal_after);
            
        }
        
    }

    class Program
    {
        static void Main(string[] args)
        {
            currentaccount c=new currentaccount("abc",10000,"current");
            try{
                savingaccount s=new savingaccount("xyz",10000,"saving");
                s.withdraw(10000);
                s.deposit(100);
                
                Console.WriteLine(s);

            }
            catch(Exception e){
                Console.WriteLine(e.Message);
            }
            c.payint(c);
            
            Console.WriteLine(c);
            c.show();
            int no_of_evens;
            int[] result;
            
            int start,end;
            Console.WriteLine("enter start and end");
            start=Convert.ToInt32(Console.ReadLine());
            end=Convert.ToInt32(Console.ReadLine());
            
            Program p=new Program();

            result=p.reteven(start,end,out no_of_evens);
            Console.WriteLine("no of evens "+no_of_evens);
            for(int j=0;j<no_of_evens;j++)
            {
                Console.WriteLine(result[j]);
                
            }
            
            

        }

        public int[] reteven(int start,int end,out int no_of_evens){
            int[] arr1=new int[end-start
            -1];
            int j=0;
            int i=0;
            for(j=start;j<end;j++){
                if(j%2==0 && j!=0){
                    arr1[i]=j;
                    i++;
                }

            }
            no_of_evens=i;
            return arr1;
        }

    }
}