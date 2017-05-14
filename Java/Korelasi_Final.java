/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */

/**
 *
 * @author Blue Spy
 */
import java.io.DataInputStream;
public class Korelasi_Final {
    public static double x[]=new double [10];
    public static double y[]=new double [10];
    public static int n = 0;
    
    public static double sX()
    {
        double out = 0;
        for(int i=0;i<n;i++)
        {
            out += x[i];
        }
        
        return out;
    }
    
    public static double sY()
    {
        double out = 0;
        for(int i=0;i<n;i++)
        {
            out += y[i];
        }
        
        return out;
    }
    
    public static double sXX()
    {
        double out = 0;
        for(int i=0;i<n;i++)
        {
            out += ( x[i] * x[i] );
        }
        
        return out;
    }
    
    public static double sYY()
    {
        double out = 0;
        for(int i=0;i<n;i++)
        {
            out += ( y[i] * y[i] );
        }
        
        return out;
    }
    
    public static double sXY()
    {
        double out = 0;
        for(int i=0;i<n;i++)
        {
            out += ( x[i] * y[i] );
        }
        
        return out;
    }
    
    public static double  Korelasi1(double  y[], double  x[], int n)
    {
        double r;
        
         r = ((n * sXY()) - (sX() * sY())) / Math.sqrt((((n * sXX()) - (sXX() * 2)) * ((n * sYY()) - (sYY() * 2))));
        
        System.out.println("Sum Y= "+sY());
        System.out.println("Sum X= "+sX());
        System.out.println("Sum XY= "+sXY());
        System.out.println("Sum XX= "+sXX());
        System.out.println("Sum YY= "+sYY());
       
        r = ((n * sXY()) - (sX() * sY())) / Math.sqrt((((n * sXX()) - (sXX() * 2)) * ((n * sYY()) - (sYY() * 2))));
        return r;
       
    }
    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        DataInputStream entri=new DataInputStream(System.in);
    try
    {
        System.out.print("Masukan n = ");
        n=Integer.parseInt(entri.readLine());
        
        System.out.println("Input x");
        for (int i=0;i<n;i++)
        {
            System.out.print("X ["+i+"] = ");
            x[i]=Double.parseDouble(entri.readLine());
        }
       
        System.out.println("Input y");
        for (int i=0;i<n;i++)
        {
            System.out.print("Y ["+i+"] = ");
            y[i]=Double.parseDouble(entri.readLine());
        }
        
        System.out.print("korelasi = "+ Korelasi1(x,y,n));
    }
    catch(Exception a)
    {
    }
    }

}
