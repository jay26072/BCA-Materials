const http = require("http");
var my=require('./arith.js');

const port=process.env.PORT || 3000;

const server=http.createServer((req,res)=>{
    res.statusCode=200;
    res.setHeader("Content-Type","text/html")
    if (err) throw err;
    res.end('<h1>'+ my.add(5,2)+'</h1>');
    res.end('<h1>'+ my.sub(5,2)+'</h1>');
    res.end('<h1>'+ my.mul(5,2)+'</h1>');
    res.end('<h1>'+ my.div(5,2)+'</h1>');
})
server.listen(port,()=>{
    console.log('Server is listeining on port ${port}');
});