<?php
	if(isset($_FILES['image'])){
		$err=array();
		$fn=$_FILES['image']['name'];
		$fs=$_FILES['image']['size'];
		$ft=$_FILES['image']['type'];
		$ftmp=$_FILES['image']['tmp_name'];
		$fext=strtolower(end(explode('.',$fn)));
		$ext=array("jpg","jpeg","gif","png");
		if($fs > 2097152){
			$err[]="File size error";
		}
		if(file_exists("upload/".$fn)){
			$err[]="File exist error";
		}
		if(in_array($fext,$ext)===false){
			$err[]="File extension error";
		}
		if(empty($err)==true){
			move_uploaded_file($ftmp,"upload/".$fn);
			echo "<br>fn : ".$fn;
			echo "<br>fs : ".$fs;
			echo "<br>ft : ".$ft;
			echo "<br>ferr : ".$_FILES['image']['error'];
		}
		else{
			print_r($err);
		}
	}
?>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
<meta http-equiv="Content-Type" content="text/html; charset=iso-8859-1" />
<title>FUP 23</title>
</head>

<body>
	<form action="" method="post" enctype="multipart/form-data">
		<input type="file" name="image"  />
		<input type="submit" />
	</form>
</body>
</html>
