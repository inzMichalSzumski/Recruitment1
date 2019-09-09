function fixage(arr) {
    var returnString = "";
    for (i = 0; i < arr.length; i++) {
        if (arr[i] >= 18 && arr[i] <= 60) {
            returnString += arr[i] + ",";
        }
    }

    if (returnString == "") {
        return "NA";
    }
    return returnString;
}

alert(fixage([18, 3, 30, 22, 11, 60]));