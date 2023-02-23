#run time error please fix it
def BS(a, n, X):
    ans = 0
    currentSum = 0
    L, R = 0, 0
    while R < n:
        currentSum += a[R]
        while currentSum > X:
            currentSum -= a[L]
            L += 1
        ans += R - L + 1
        R += 1
    return ans

n, q = map(int, input().split())
a = list(map(int, input().split()))

for i in range(q):
    x = int(input())
    print(BS(a, n, x))
