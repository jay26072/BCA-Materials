<?php
    include ('connection.php');
	session_start();
	if($_SESSION['username']=="")
	{
	     header('location:index.php');
	}
	echo "Hello"."   ".$_SESSION['username'];
	//Logic for display records
	$query="select * from student";
	$result=mysql_query($query);
	 while($row = mysql_fetch_array($result))
     {
	 $rs[]=$row;
     }
	 /*echo "<pre>";
	 print_r($rs);
	 echo "</pre>";*/
	 //Logic for Delete
	 $id=$_GET['id'];
	  if($id!="")
	  {
	  $query="delete from student where stu_id=$id";
	  mysql_query($query);
      header('location:display.php');		 
	  }
	
	 //echo $id;
?>
<html>
      <head>
	    <title>display records</title>
	  </head>
	  <body>
			    <a href="registration.php">Add Record</a>
				<a href="logout.php">LOGOUT</a>
			 
		<table border=1 align="center">
		     
			 <tr>
			     
				 <th>Username</th>
				 <th>City</th>
				 <th>Email</th>
				 <th>Contact</th>
				 <th colspan="2">Action</th>
							 
			 </tr>
			 <?php for($i=0;$i<count($rs);$i++)
			    {?>
			 <tr>
			    
				 <td><?php echo $rs[$i]['username']?></td>
				 <td><?php echo $rs[$i]['city']?></td>
				 <td><?php echo $rs[$i]['email']?></td>
				 <td><?php echo $rs[$i]['contact']?></td>
				 <td><a href="edit.php?id=<?php echo $rs[$i]['stu_id'];?>">Edit</td>
				 <td><a href="display.php?id=<?php echo $rs[$i]['stu_id'];?>"
				 onClick="return confirm('Are you sure you want to delete?')">
				 Delete</a></td>
			 </tr>
			 <?php }?>
		 </table>
	  </body>
</html>