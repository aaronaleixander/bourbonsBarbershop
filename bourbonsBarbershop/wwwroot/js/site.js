// The following JavaScript is to get the total stroke marks in the text/font. Main logo title on home page.
const logo = document.querySelectorAll('#logo path');
console.log(logo);
// Get totoal number of stroke marks.
for (let i = 0; i < logo.length; i++) {
    console.log(`Letter ${i} is ${logo[i].getTotalLength()}`); //ES6 Syntax
}