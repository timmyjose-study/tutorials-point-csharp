public class Varargs {
  public static void main(String[] args) {
    System.out.printf("%d\n", sumArray(1, 2, 3, 4, 5));
    System.out.printf("%d\n", sumArray(1, 2, 3));
    System.out.printf("%d\n", sumArray());
  }

  static int sumArray(int... arr) {
    int sum = 0;
    for (int e : arr) {
      sum += e;
    }
    return sum;
  }
}