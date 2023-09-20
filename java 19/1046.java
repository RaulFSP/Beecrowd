import java.io.IOException;
import java.util.Scanner;
public class Main {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);        
        int n1 = sc.nextInt();
        int n2 = sc.nextInt();
        int resultado = 0;
        if (n1 < n2){
            resultado = (n2-n1);
        } else if (n1 == n2){
            resultado = (24);
        } else {
            resultado = ((24-n1)+n2);
        }
        System.out.printf("O JOGO DUROU %d HORA(S)\n",resultado);
        sc.close();
    }
}
