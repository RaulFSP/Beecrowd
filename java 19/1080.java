import java.io.IOException;
import java.util.ArrayList;
import java.util.Scanner;
import java.util.Collections;

public class Main {
 
    public static void main(String[] args) throws IOException {
 
        ArrayList <Integer> lista = new ArrayList<>();
    	Scanner sc = new Scanner(System.in);
		for(int i = 0; i < 100; i++){
            lista.add(sc.nextInt());
        }
        System.out.println(Collections.max(lista));
        System.out.println(lista.indexOf(Collections.max(lista))+1);
    }
}
