import java.io.IOException;
import java.util.Scanner;
import java.util.Arrays;
public class Main {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);        
        double n1 = sc.nextDouble();
        double n2 = sc.nextDouble();
        double n3 = sc.nextDouble();
        double n4 = sc.nextDouble();
        sc.nextLine();
        int[] pesos = {2,3,4,1};
        int somaPesos = Arrays.stream(pesos).sum();
        double media = (n1*pesos[0]+n2*pesos[1]+n3*pesos[2]+n4*pesos[3])/somaPesos;
        media = Math.floor(media*10)/10;
        System.out.printf("Media: %.1f\n",media);
        if (media < 5.0) {
            System.out.println("Aluno reprovado.");
        } else if (media >= 7) {
            System.out.println("Aluno aprovado.");
        } else {
            System.out.println("Aluno em exame.");
            double nExame = sc.nextDouble();
            sc.nextLine();
            System.out.printf("Nota do exame: %.1f\n",nExame);
            double mediaFinal = (media + nExame)/2.0;
            String resultadoFinal = (mediaFinal >= 5.0) ? "Aluno aprovado." : "Aluno reprovado.";
            System.out.println(resultadoFinal);
            System.out.printf("Media final: %.1f\n", mediaFinal);
        }
        sc.close();
    }
}
