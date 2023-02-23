import java.util.*;

public class Main {
    public static long BS(List<Long> a, int n, long X) {
        long ans = 0;
        long currentSum = 0;
        int L = 0, R = 0;
        while (R < n) {
            currentSum += a.get(R);
            while (currentSum > X) {
                currentSum -= a.get(L++);
            }
            ans += R - L + 1;
            R++;
        }
        return ans;
    }

    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        int n = sc.nextInt();
        int q = sc.nextInt();
        List<Long> a = new ArrayList<>();
        for (int i = 0; i < n; i++) {
            a.add(sc.nextLong());
        }
        while (q-- > 0) {
            long x = sc.nextLong();
            System.out.println(BS(a, n, x));
        }
    }
}
