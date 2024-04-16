using System;
namespace InterfaceDemo
{    //default it is internal
    interface ImessageService
    {       //by default it is public
        void SendMessage(string address);
    }
    class parent
    {   public void SendMessage(string address)
        { Console.WriteLine("parent send message"); }
    }
    class Email :parent, ImessageService
    {
       /* public  void SendMessage(string address)
        {
           // Console.WriteLine("Sending Email to {0}", address);
        }*/
      }

    interface I1
    {
        void A();
    }
    interface I2
    {
        void A();
    }
    class C : I1, I2
    {
        public void A()
        {
            Console.WriteLine("C.A()");
        }
    }

   class Program
    {
        static void Main(string[] args)
        {            Email eobj = new Email();
                  eobj.SendMessage("DBDA");
                  eobj.SendMessage("pp");
                  C c = new C();
                 I1 i1 = c; 
                 I2 i2 = c;

                i1.A();
                i2.A();
                c.A();

                }
    }
}
