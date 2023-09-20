import java.io.IOException;
import java.util.Scanner;
import java.lang.Math;
public class Main {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        double x = sc.nextDouble();        
        double a = Math.pow(x,2)*3.14159;
        System.out.printf("A=%.4f\n",a);
        sc.close();
    }
}
