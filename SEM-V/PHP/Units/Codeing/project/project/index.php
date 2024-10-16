<?php
   include('connection.php');
   session_start();
   $username=$_POST['uname'];
   $password=$_POST['pass'];
   if($_POST['submit'])
   {
        $Sel_query="Select * from login where
		username='$username' and password='$password'";
	    $rs=mysql_query($Sel_query);
        $row=mysql_fetch_row($rs);		
		if($username=="")
		{
 			$error= "Please enter username";	
		}
		else if(empty($password))
		{
		     $error1= "Please enter password";
		}
		else if($row)
		{
		    $_SESSION['username']=$row[0];
			header('location:display.php');
		}
		else
		{
		   echo "<font color='red'>"."Username and password are not Valid"."</font>";
		}
     }
   
?>
<html>
  <head>
      <title>Login</title>
  </head>
   <body>
       <form name="regis" method="post">
	       Username=<input type="text" name="uname" 
		   value="<?php echo $username;?>">
		   <font color='red'><?php echo $error;?></font><br>
		  
		  password=<input type="password" name="pass">
		  <font color='red'><?php echo $error1;?></font><br>
		   
		   <input type="submit" name="submit" value="submit">
	   </form>
   </body>   
</html>