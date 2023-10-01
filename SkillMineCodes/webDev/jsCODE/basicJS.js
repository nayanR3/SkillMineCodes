

var add = (a, b) => {
    return a + b;
}

console.log(add(1, 2));


setInterval(() => {
    var date = new Date();
    var current_time = date.getHours() + ":" + date.getMinutes() + ":" + date.getSeconds();

    console.log(current_time)
}, 1000)


setInterval()