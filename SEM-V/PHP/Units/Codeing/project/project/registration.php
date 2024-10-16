<?php
   include('connection.php');
   $username=$_POST['uname'];
   $password=$_POST['pass'];
   $cpassword=$_POST['cpass'];
   $city=$_POST['city'];
   $email=$_POST['email'];
   $cno=$_POST['contact'];
  if($_POST['submit'])
   {
        if($username=="")
		{
 			$error= "Please enter username";	
		}
		else if(is_numeric($username))
		{
		    $error= "Please enter character only";
		}
		else if(empty($password))
		{
		     $error1= "Please enter password";
		}
		else if(empty($cpassword))
		{
		     $error2= "Please enter confirm password";
		}
		else if($password!=$cpassword)
		{
		   $error2= "Password mismatch";
		}
		else if ($email=="")
	 {
		   $error3="email can not be blank";
	 }
	 else if(filter_var($email, FILTER_VALIDATE_EMAIL) === false)
	 {
		 $error3="email is not valid";
		 
	 }
	 else if($cno=="")
	 {
		 
		 $error4= "Contact no is not blank";
	 }
	 else if(!is_numeric($cno))
	 {
		 
		 $error4="Only numbers are allowed";
	 }
	 else if(!preg_match('/^[0-9]{10}+$/', $cno))
	{
		$error4="exact 10 digits are allowed";
	}
		else
		{
		     $query="insert into student(username,password,cpassword,city,email,contact)values('$username','$password','$cpassword','$city','$email',$cno)";
			 mysqli_query($con,$query);
			 header('location:display.php');
		}
   }
?>
<html>
  <head>
      <title>Registration</title>
  </head>
   <body>
       <form name="regis" method="post">
	       Username=<input type="text" name="uname" value="<?php echo $username;?>"><font color='red'><?php echo $error;?></font><br>
		   password=<input type="password" name="pass"><font color='red'><?php echo $error1;?></font><br>
		   confirm password=<input type="password" name="cpass"><font color='red'><?php echo $error2;?></font><br>
		   city=<select name="city">
		             <option value="Surat">Surat</option>
					 <option value="Navsari">Navsari</option>
					 <option value="Bharuch">Bharuch</option>
		        </select><br>
		   Email=<input type="text" name="email" value="<?php echo $email;?>"><font color='red'><?php echo $error3;?></font><br>
		   Contact No=<input type="text" name="contact" value="<?php echo $cno;?>"><font color='red'><?php echo $error4;?></font><br>
		   <input type="submit" name="submit" value="submit">
	   </form>
   </body>   
</html>