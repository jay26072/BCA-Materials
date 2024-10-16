const http=require('http');
const url=require('url');
http.createServer(function(req,res)
{
    const queryobj=url.parse(req.url,true).query;
    console.log(queryobj);
    res.writeHead(200, {'Content-Type': 'text/html'}); 
    res.end('Feel query parameters to the end of the url'); 
}).listen(8000);