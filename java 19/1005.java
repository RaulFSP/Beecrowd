import java.io.IOException;
import java.util.Scanner;
import java.util.ArrayList;
public class Main {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        ArrayList <Double> lista = new ArrayList<Double>();
        lista.add(Double.parseDouble(sc.next())*3.5);
        lista.add(Double.parseDouble(sc.next())*7.5);
        double soma = 0;
        for(Double n:lista){
            soma+=n;
        }
        System.out.printf("MEDIA = %.5f\n",soma/11.0);
        sc.close();
    }
}
