function optionalPow(firstNum, secondNum) {
    if (confirm('Do you agree?')) {
        return Math.pow(firstNum, secondNum);
    } else {
        return Math.pow(secondNum, firstNum);
    }
}

alert(optionalPow(2, 3));
