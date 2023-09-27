import java.util.Scanner;
import java.io.IOException;

public class Main {
    public static void main(String[] args) throws Exception {
		Scanner sc = new Scanner(System.in);
		int entrada = 1;
		do{
			entrada = sc.nextInt();
			sc.nextLine();
			if (entrada == 0){
				break;
			}
			int conte = 0;
			int soma = 0;
			while(conte < 5){
				if(entrada%2 == 0){
					soma += entrada;
					conte++;
				}
				entrada++;
			}
			System.out.println(soma);
		}while(true);
    }
}
