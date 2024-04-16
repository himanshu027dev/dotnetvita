using System.Security.Cryptography.X509Certificates;
using Classlibrary;

namespace refadd{
    class prac:MyMathLib{
        
        public static void Main(string[] args)
        {
            Classlibrary.Child ch= new Classlibrary.Child();
            //Classlibrary.MyMathLib mml= new Classlibrary.MyMathLib();
            //Classlibrary.usemath um= new Classlibrary.usemath();   
           // mml.sum(1,3);
            //mml.cube(4);
            prac geo= new prac();
           // geo.sqr(2);
            ch.usepmathad();
            usemath.makeObj();
            geo.docall();
            calls();
        }
        public void docall(){
            sum(1,2);
            cube(2);
            sqr(9);
        }
        public static void calls(){
          // Classlibrary.usemath op=new Classlibrary.usemath();
           // usemath.makeObj();
            Classlibrary.Child k=new Classlibrary.Child();
            k.usepmathad();
            Classlibrary.MyMathLib klao= new Classlibrary.MyMathLib();
           // klao.sum(1,2);
            //klao.cube(4);
            klao.sqr(2);
           // sum(2,2);
        }
    }
}