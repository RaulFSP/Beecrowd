import java.io.IOException;
import java.util.Scanner;
public class Main {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);        
        double x1 = sc.nextDouble();
        double y1 = sc.nextDouble();
        double x2 = sc.nextDouble();
        double y2 = sc.nextDouble();
        sc.nextLine();
        double p = Math.pow(x2-x1,2) + Math.pow(y2-y1,2);
        p = Math.sqrt(p);
        String resultado = String.format("%.4f", p);
        System.out.println(resultado);
        sc.close();
    }
}
