<?php
$conn = new mysqli('localhost','root','admin1234','realty');
if($conn->connect_error)
{
  echo "Error: " . $conn->connect_error . "\n";
}
?>
