using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape
{
    public delegate void del(string x);
    public delegate string del2();
    public class PS
    {
        
        public static void Pm(del m, del2 m2) { m(m2());  }
            

        

    }


   abstract class Shape
    {
       
	protected int dim1, dim2;
        
	  public  Shape()
        {
            dim1 = dim2 = 0;
        }
     public   Shape(int m)
        {
            dim1 = dim2 = m;
        }
      public  Shape(int m, int n)
        {
            dim1 = m;
            dim2 = n;
        }
        public void SetD1(int m)
        {
            dim1 = m;
        }
        void SetD2(int n)
        {
            dim2 = n;
        }
        public int GetD1() { return dim1; }
        public int GetD2() { return dim2; }


        public abstract double Area();
};

    class Circle : Shape{


   public Circle()
    {
    }

   public Circle(int r) : base(r)
    {
    }
    public override double Area() { return 3.14 * dim1 * dim2; }


};

     class Rectangle :  Shape{


    public Rectangle()
{
}

    public Rectangle(int l, int w) : base(l, w)
{
}
      public  override double  Area() { return 1.0 * dim1 * dim2; }
};

 class Triangle : Shape{


   public Triangle()
{
            
}

   public Triangle(int b, int l) : base(b, l)
{
}
        public override double Area() { return 0.5 * dim1 * dim2; }
};
   public interface Iiam 
    {
         double get();

    }

class Square :  Rectangle , Iiam {

        
   public Square()
{
}

   public Square(int s) : base(s, s)
{
}
        public double get()
        {
            Square sq = new Square(2);
            return sq.Area();

        }
        
};
class GeoShape
{
        Shape[] ptr;



   public GeoShape(params Shape[] s)
    {
            ptr = new Shape[s.Length];
            for (int i = 0; i < s.Length; i++)
            {
                ptr[i] = s[i];
            }
        
        

    }

   public double TotalArea()
    {
        Double sum = 0;
        for (int i = 0; i < ptr.Length; i++)
        {
                sum += ptr[i].Area();
        }
        return sum;
    }

};

    class Program
    {
        public static void Main()
        {
            // del testDelC = new del()
            //  del testDelC = () => { Console.WriteLine("Hello"); };
            
            PS.Pm((x) => {  Console.WriteLine(x.ToString()); }, () => { return Console.ReadLine(); });

            ArrayList al = new ArrayList();
            
            

            Circle c = new Circle(1);
            
            Rectangle r = new Rectangle(1, 1);
            
            Triangle t = new Triangle(1, 1);
            
            Square s = new Square(1);
            
            GeoShape g = new GeoShape(s);

            Console.WriteLine(g.TotalArea());
            Iiam iam = (Iiam)s;
            Console.WriteLine(iam.get());
            Console.ReadKey();
        }
    }


}
