using System;

namespace endofallaccount{
    class account{

        static account(){
            Console.WriteLine("run! bitch! run!\n @or you will lose all savings");
        }
        private string name;
        private int accid;
        private double balance;

        public string accname{
            get{ return name;}
            set{ name=value;}
        }
        public int accountid{
            get{ return accid;}
            set{ accid=value;}
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
    }
    class currentaccount : account{
        string s;
        public currentaccount(int id,string name,double balance,string k){
                accname=name;
                accountid=id;
                accbalance=balance;
                s=k;
        }
        public string toString(){
            return "account name: "+accname+"\naccount id: "+accountid+"\naccount balance: "+accbalance+"\nTYPE OF ACCOUNT"+s;
        }



        
    }
    class savingaccount : account{
        string s;
        public savingaccount(int id,string name,double balance,string k){
                
                if(balance<0){
                       throw new Exception("err"); 
                }else{
                accbalance=balance;
                accname=name;
                accountid=id;
                s=k;}
        }

        public void withdraw(int amt){
            if(accbalance<amt){
                throw new Exception("err");
            }
            else{
                accbalance=accbalance-amt;
            }
        }
        public string toString(){
            return "account name: "+accname+"\naccount id: "+accountid+"\naccount balance: "+accbalance+"\nTYPE OF ACCOUNT"+s;
        }
        
    }

    class Program
    {
        static void Main(string[] args)
        {
            currentaccount c=new currentaccount(1,"abc",10000,"current");
            try{
                savingaccount s=new savingaccount(2,"xyz",10000,"saving");
                s.withdraw(10000);
                
                Console.WriteLine(s.toString());

            }
            catch(Exception e){
                Console.WriteLine(e.Message);
            }
            Console.WriteLine(c.toString());
        }
    }
}