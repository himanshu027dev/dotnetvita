using System;

namespace Classlibrary{
    public class MyMathLib{

        public void sqr(int x)
        {
            Console.WriteLine("Square of "+x+" is : " + x*x);
        }
        protected void cube(int x)
        {
            Console.WriteLine("Cube of "+x+" is : " + x*x*x);
        }
        protected internal void sum(int x,int y){
            Console.WriteLine("sum="+(x+y));
        }

    }

    public class Child:MyMathLib{
        public void usepmathad(){
           sum(2,3);
           cube(3);
            
        }
    }
    public class usemath{
        public static void makeObj(){
            MyMathLib obj = new MyMathLib();
            obj.sqr(2);
            
            obj.sum(2,3);
        }
    }
        
            
}