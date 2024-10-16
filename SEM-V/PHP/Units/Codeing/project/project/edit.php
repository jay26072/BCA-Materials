<?php
   include('connection.php');
   $username=$_POST['uname'];
   $city=$_POST['city'];
   $email=$_POST['email'];
   $cno=$_POST['contact'];
   $id=$_GET['id'] ;
   //echo $id;
   $query="Select * from student where stu_id=$id";
   $result=mysql_query($query);
   $rs=mysql_fetch_row($result);
  /* echo "<pre>";
   print_r($rs);
   echo "</pre>";*/
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
            $query="update student set username='$username',
			city='$city',email='$email',contact=$cno 
			where stu_id=$id";
            mysql_query($query);
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
	       Username=<input type="text" name="uname" value="<?php echo $rs[1];?>"><font color='red'><?php echo $error;?></font><br>
		  
		   city=<select name="city">
		       
	<option value="Surat"<?php if($rs[4]=='Surat'):?>
	selected="selected"<?php endif;?>>Surat</option>
	<option value="Navsari"<?php if($rs[4]=='Navsari'):?>selected="selected"<?php endif;?>>Navsari</option>
	<option value="Bharuch"<?php if($rs[4]=='Bharuch'):?>selected="selected"<?php endif;?>>Bharuch</option>
		        </select><br>
		   Email=<input type="text" name="email" value="<?php echo $rs[5];?>"><font color='red'><?php echo $error3;?></font><br>
		   Contact No=<input type="text" name="contact" value="<?php echo $rs[6];?>"><font color='red'><?php echo $error4;?></font><br>
		   <input type="submit" name="submit" value="submit">
	   </form>
   </body>   
</html>