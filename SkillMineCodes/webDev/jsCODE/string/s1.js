var text1 = "This is a sample text";
var text2 = "This is a sample text of another string";

let a = text1.charAt(1);
console.log("char at : "+a);

var res1 = text1.concat(' ',text2);
console.log("concat : "+res1);



var res2 = text1.slice(' ');
console.log("slice : "+res2);


text1 = text1.replace("This", "THIS");  //replace 1st occurrence
console.log(text1);


text2 = text2.replace(/i/g, 'I');  //replace all occurrence
console.log(text2);


// console.log(text1.toLowerCase());
//console.log(text1.toUpperCase());

//trim()
console.log(text1.indexOf("Is")); // return the index of Is ,which match at first occurance
console.log(text1.lastIndexOf('I')); // return the index of Is ,which match at first occurance

var t = text.substring(1, 9);
var t2 = text.substring(3);
console.log(t);
console.log(t2);
