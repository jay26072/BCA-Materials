var fs = require('fs'); 
//fs.appendFile('newfile.txt', 'Hello SYBCA',function(err){
//fs.open('newfile1.txt','w',function (err,file) { 
    fs.writeFile('newfile2.txt', 'Hello SYBCA',function(err){
    if (err) throw err; 
console.log('Done!'); 
});