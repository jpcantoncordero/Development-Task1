<?php include_once 'includes/templates/headerC.php'?>
    <!-- PAGE BODY -->
    <div class="container marketing">
    <div class="content">
      <div class="card">
        <div class="icon"><i class="fa fa-map-marker"></i></div>
            <p class="title">Our address</p>
            <p class="text">Culture Street, San José de la Rinconada</p>
         
      </div>
      <!-- end card -->
      <!-- card -->
      <div class="card">
         
            <div class="icon"><i class="far fa-envelope" ></i></div>
            <p class="title">Our email</p>
            <p class="text">realtyhousing@gmail.com</p>
         
      </div>
      <!-- end card -->
      <!-- card -->
          <div class="card">
            <div class="icon"><i class="fas fa-phone-alt"></i></div>
            <p class="title">Our phone</p>
            <p class="text">0-123-456-789</p>
         
          </div>
      <!-- end card -->
    </div>
      </div>
  </div>
    </div>
    </div>
<div class="container-contact">
  <div id="mymap" class="map">
  </div>
   
    <div class="wrap-contact">
      <form action="submit_contact.php" class="contact-form validate-form" id="contact" method="post">
        <span class="contact-form-title">
          Contact us
        </span>
        <div class="wrap-input validate-input" data-validate="Name is required">
          <span class="label-input">Name</span>
          <input class="input" id="name" type="text" name="name" placeholder="Name...">
            <span class="focus-input">
            </span>
        </div>
        <div class="wrap-input validate-input" data-validate="Valid email is required: ex@abc.xyz">
          <span class="label-input">Email</span>
          <input class="input" id= "email" type="text" name="email" placeholder="Email address...">
            <span class="focus-input">
          </span>
        </div>
        <div class="wrap-input">
          <span class="label-input">Phone</span>
          <input class="input" id="phone" type="text" name="phone" placeholder="Phone Number...">
          <span class="focus-input">
          </span>
        </div>
        <div class="wrap-input validate-input alert-validate" data-validate="Message is required">
          <span class="label-input">Message</span>
          <textarea class="input" id="message" name="message" placeholder="Questions/Comments..." style="margin-top: 0px,;margin-bottom: 0px;height:140px;"></textarea>
          <span class="focus-input">
          </span>
        </div>
        <div class="container-contact-form-btn">
          <div class="wrap-contact-form-btn">
            <div class="contact-form-bgbtn">
              <input class="button1 btn btn--alpha" type="submit" id="contact" name="submit" value="send">
            </div>
          </div>
        </div>
       
      </form>
    </div>
  </div>

  <?php include_once 'includes/templates/footerMP.php'?>