import java.io.IOException;
import java.util.Scanner;

public class Main {
 
    public static void main(String[] args) throws IOException {
 
        Scanner sc = new Scanner(System.in);
        int ano = 0, mes = 0, dia = 0;
        int entrada = sc.nextInt();
        sc.nextLine();
        ano = entrada / 365;
        mes = entrada % 365 / 30;
        dia = entrada % 365 % 30;
        System.out.printf("%d ano(s)\n",ano);
        System.out.printf("%d mes(es)\n",mes);
        System.out.printf("%d dia(s)\n",dia);
        sc.close();
 
    }
 
}
