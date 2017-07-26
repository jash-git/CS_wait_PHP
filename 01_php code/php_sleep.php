<?php
	header('content-type:text/html;charset=utf-8');
	set_time_limit(0);//確保不會超時
	date_default_timezone_set("Asia/Taipei");//設定時區
	//echo "start....".date ("Y- m - d / H : i : s") ."<br>";
	//echo "\n";
	$data = file_get_contents("php://input");
	sleep(30);//函數延遲代碼執行若干秒。
	echo $data."_".date ("Y- m - d / H : i : s");
	//echo "end....".date ("Y- m - d / H : i : s")."<br>";
?>