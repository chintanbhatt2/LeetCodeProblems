// 59. Spiral Matrix II

/**
 * @param {number} n
 * @return {number[][]}
 */
var generateMatrix = function(n) {

    let retMatrix = []
    for (var i = 0; i < n; i++) {
        retMatrix[i] = new Array(n).fill(0);
    }
    let number = 1
    let upperL = [0, 0]
    let upperR = [0, n - 1]
    let lowerL = [n - 1, 0]
    let lowerR = [n - 1, n - 1]
    while (number <= n * n) {
        for (let i = upperL[1]; i <= upperR[1]; i++) {
            retMatrix[upperL[0]][i] = number;
            number++;
        }
        upperL[0]++;
        upperR[0]++;
        for (let i = upperR[0]; i <= lowerR[0]; i++) {
            retMatrix[i][upperR[1]] = number;
            number++;
        }
        upperR[1]--;
        lowerR[1]--;
        for (let i = lowerR[1]; i >= lowerL[1]; i--) {
            retMatrix[lowerR[0]][i] = number;
            number++;
        }
        lowerR[0]--;
        lowerL[0]--;
        for (let i = lowerL[0]; i >= upperL[0]; i--) {
            retMatrix[i][lowerL[1]] = number;
            number++;
        }

        lowerL[1]++;
        upperL[1]++;
    }

    return retMatrix;
};


console.log(generateMatrix(5))