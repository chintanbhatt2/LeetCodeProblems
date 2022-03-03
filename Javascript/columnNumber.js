/**
 * @param {number} columnNumber
 * @return {string}
 */
var convertToTitle = function(columnNumber) {
    if (columNumber < 27) {
        String.fromCharCode(64 + columnNumber)
    }

};