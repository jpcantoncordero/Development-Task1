
<?php include_once 'includes/templates/headerMP.php';?>

<section class="container new-section">
  <h2>Registration</h2>
  <?php
    if(isset($_POST['submit'])){
     
        $name = $_POST['name'];
        $email = $_POST['email'];
        $phone= $_POST['phone'];
        $message = $_POST['message'];
        $date = date('Y-m-d H:i:s');

    try{
        require_once('includes/functions/db_connection.php');
        $last_id = $conn->insert_id;
        $sql = ("INSERT INTO contacts (id,name, email, phone_number,message,reg_date) VALUES ($last_id, '$name', '$email', '$phone', '$message', '$date')");
        if( mysqli_query($conn,$sql)){
        echo "<h3> {$name}'s message will be checked by our workers. </h3>";
        }else{
            echo "Error: " . $sql . "" . mysqli_error($conn);
        }
    
    }
    catch(Exception $e){
        $error = $e->getMessage();
    }
    }
?>
</section>

<?php include_once 'includes/templates/footerMP.php' ?>
