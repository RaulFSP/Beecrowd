import java.io.IOException;
import java.util.Scanner;
public class Main {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        int x = 0;
        x += sc.nextInt();
        x += sc.nextInt();
        sc.nextLine();
        System.out.printf("X = %d\n",x);
    }
}
