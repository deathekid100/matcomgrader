#include <bits/stdc++.h>
typedef long long LL;
using namespace std;
LL BS(vector<LL> a, int n, LL X) {
	LL ans = 0;
	LL currentSum = 0;
	int L = 0, R = 0;
	while (R < n)
	{
		currentSum += a[R];
		while (currentSum > X) {
			currentSum -= a[L++];
		}
		ans += R - L + 1;
		R++;
	}
	return ans;
}
int main()
{
	ios_base::sync_with_stdio(0);
	cin.tie(0);
	int n, q;
	cin >> n >> q;
	vector<LL> a(n);
	LL x;
	for (int i = 0; i < n; i++)
	{
		cin >> a[i];
	}

	while (q--) {
		cin >> x;
		cout << BS(a,n,x) << "\n";
	}
}
