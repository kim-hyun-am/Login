<?php

//unity import
$user = $_POST['Input_user'];
$pass = $_POST['Input_pass'];

// mysql의 아이디와 비밀번호를 입력해준다. 
$con = mysql_connect("gusdka3.dothome.co.kr/myadmin","gusdka3","wlwhs!23") or 
("Cannot connect!" .mysql_error());
if(!$con)
	die('Cound not Connect:' . mysql_error());

mysql_select_db("gusdka3",$con) or die ("could not load the database" .mysql_error());


$check = mysql_query("SELECT * FROM zombi WHERE `user`='".$user."'");  //zombi라는 테이블에서 내가 입력한 ID값을 찾겠다. 


// Mysql_num_row()함수는 데이터베이스에서 쿼리를 보내서 나온 레코드의 개수를 알아낼때 쓰임.
// 즉 0이 나왔다는 뜻은 내가 내가 찾는 ID값이 없다는 것이다. 

$numrows = mysql_num_rows($check);    
if ($numrows == 0)
{
	
	die("ID does not exist. \n");


}

else
{

  while($row = mysql_fetch_assoc($check))
  {
	if($pass == $row['pass'])
	{	
	//정보를 불러온다. 
        echo ("'".$row ['Info']."' \n");
	die("Login-Success!!");
	
	
	}
	
	else
		die("Pass does not Match. \n");
   }

}

?>