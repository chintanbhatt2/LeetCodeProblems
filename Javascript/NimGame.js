/**
 * @param {number} n
 * @return {boolean}
 */
var canWinNim = function(n, memo = {}, yourTurn = true) {
    if (n + ',' + yourTurn in memo) return memo[n + ',' + yourTurn];
    if (n === 4 && yourTurn) return false;
    if (n < 4 && yourTurn) return true;
    if (n === 4 && !yourTurn) return true;
    if (n < 4 && !yourTurn) return false;

    let retBool = false;
    if (yourTurn) {
        for (let i = 1; i <= 3; i++) {
            retBool |= canWinNim(n - i, memo, !yourTurn)
        }
    }
    if (!yourTurn) {
        for (let i = 1; i <= 3; i++) {
            retBool &= canWinNim(n - i, memo, !yourTurn)
        }
    }

    memo[n + ',' + yourTurn] = retBool;
    return retBool;

};


console.log(canWinNim(9))

// DP problem = Memoization with recursive calls
// Base Cases:
// 1). 4 stones return false
// 2). <4 stones return true