var fs = require('fs'); 
//fs.appendFile('newfile.txt', 'SYBCA-4 ',function(err){
    fs.writeFile('newfile3.txt', 'SYBCA-4 ',function(err){
if (err) throw err; 
console.log('Saved!'); 
});