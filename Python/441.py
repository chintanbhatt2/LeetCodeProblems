class Solution:
    def arrangeCoins(self, n: int) -> int:
        total = (int)((2*n)**0.5)
        s = (total * (total+1))/2
        if s > n:
            return (int)(total-1)
        return (int)(total)
        