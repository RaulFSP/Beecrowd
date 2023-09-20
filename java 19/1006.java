import java.io.IOException;
import java.util.Scanner;
import java.util.ArrayList;
public class Main {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        ArrayList <Double> lista = new ArrayList<Double>();
        lista.add(Double.parseDouble(sc.next())*2);
        lista.add(Double.parseDouble(sc.next())*3);
        lista.add(Double.parseDouble(sc.next())*5);
        double soma = 0;
        for(Double n:lista){
            soma+=n;
        }
        System.out.printf("MEDIA = %.1f\n",soma/10.0);
        sc.close();
    }
}
