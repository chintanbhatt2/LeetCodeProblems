/**
 * @param {number} x
 * @param {number} y
 * @return {number}
 */
var hammingDistance = function(x, y) {
    let result = x ^ y;
    let counter = 0;
    while (result != 0) {
        counter += result & 1;
        result = result >> 1
    }

    return counter;
};


console.log(3 & 1)
console.log(hammingDistance(3, 1))