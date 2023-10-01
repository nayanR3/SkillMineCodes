function Addition() {
    var n1 = document.getElementById("n1").value;
    var n2 = document.getElementById("n2").value;

    var sum = parseInt(n1) + parseInt(n2);
    document.getElementById("n3").value = sum;
}

function Subtraction() {
    var n1 = document.getElementById("n1").value;
    var n2 = document.getElementById("n2").value;

    var sum = parseInt(n1) - parseInt(n2);
    document.getElementById("italicFont").innerHTML = sum;
}

function Multiplication() {
    var n1 = document.getElementById("n1").value;
    var n2 = document.getElementById("n2").value;

    var sum = parseInt(n1) * parseInt(n2);
    document.getElementById("para").innerHTML = sum;
}

function Division() {
    var n1 = document.getElementById("n1").value;
    var n2 = document.getElementById("n2").value;

    var sum = parseInt(n1) / parseInt(n2);
    document.getElementById("boldFont").innerHTML = sum;
}

function Clear() {
    var s ="";
    document.querySelector("n1").value = s;
    document.querySelector("n2").value = s;
}

