import java.io.IOException;
import java.util.ArrayList;
import java.util.Scanner;

public class Main {
 
    public static void main(String[] args) throws IOException {
        Scanner sc = new Scanner(System.in);
		ArrayList <Integer> lista = new ArrayList<>();

		int casos = sc.nextInt();
		sc.nextLine();
		for(int i = 0; i < casos; i ++){
			
			int x = sc.nextInt();
			int y = sc.nextInt();
			sc.nextLine();			
			int contador = 0;
			
			while(contador < y){
				if (x % 2 != 0){
					lista.add(x);
					contador++;					
				}
				x++;
			}
			System.out.println(lista.stream().mapToInt(Integer::intValue).sum());
			lista.clear();
		}
		sc.close();
    }
}
