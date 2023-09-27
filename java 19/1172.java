import java.util.ArrayList;
import java.util.Scanner;
import java.io.IOException;

public class Main {
    public static void main(String[] args) throws Exception {
		Scanner sc = new Scanner(System.in);
		ArrayList <Integer> lista = new ArrayList<>();
		for(int i = 0; i < 10; i++){
			Integer numero = sc.nextInt();
			if(numero <= 0){
				numero = 1;
			}
			lista.add(numero);
		}
		for(int i = 0; i < lista.size(); i++){
			System.out.printf("X[%d] = %d\n",i,lista.get(i));
		}
		sc.close();
    }
}
