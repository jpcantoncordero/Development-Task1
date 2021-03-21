:root{
  --fontCormorant: 'Cormorant Unicase', serif;
  --fontBebas:'Bebas Neue', cursive;
  /*--mycolorblue: rgb(109, 240, 240);*/
  --mycolorspaceblue:cornflowerblue;
  --mycolorwhitelowopacity: rgba(255,255,255,0.80);
  --mycolorgreydark: #3c3d41;
  --mycolorgrey: rgba(255,255,255,0.70);
}

*{
    box-sizing: border-box;
}

body {
    margin: 0;
    font-weight: 500;
    flex-direction: column;
    display: flex;

}
@media(max-width:768px){
    body{
       overflow-x:hidden;
       
    }
}

header{
    border-bottom: 1px solid white;
}
footer{
    display:block;
}


header::after {
    content: "";
    display: table;
    clear: both;
}

header .container{
    width: 90%;
    margin: 0 auto;
}
@media (min-width:768px) {
    header .container{
      width: 90%;
    }
  }

.video-container{
    max-width: 110%;
    overflow-x: hidden;
    overflow-y: hidden;
    height: 2px;
    grid-column: 1 / 3;
    grid-row: 1 / 2;
    line-height: 0;
}
@media (max-width: 768px){
    .video-container{
        overflow-inline: scroll;
        place-content: center;

    }
}

img {
    float: left;
    padding: 3px 0;
    margin-top:5px;    
}


h1{
    font-family: var(--fontBebas);
    text-transform: uppercase;
    font-size: 3rem;
    text-align: left;
}

p{
    font-family: var(--fontBebas);
    text-transform: capitalize;
    font-size: 1.5rem;
    text-align: left;
}

nav{
    float: right;
}

nav ul{
    margin-bottom: 3;
    padding: 0;
    list-style: none;   
    
}

nav li{
    display: inline-block;
    margin-left: 70px;
    padding-top: 10px;
    position: relative;
    font-family: var(--fontCormorant);
}

.button{
    color: whitesmoke;
    position: relative;
    text-transform: uppercase;
    background-color: transparent;
    font-size: 16px;
    border: none;
    outline:none;
    cursor: pointer;
   padding: 1em 1.5em;  
}

.button.outline{
    color:white;
    font-family: var(--fontBebas);
}

.button.outline::after,
.button.outline::before{
    content: "";
    display: block;
    position: absolute;
    height: 20%;
    width: 20%;
    border: 2px solid;
    transition: all 0.6s ease;
    border-radius: 2px;
    /*background-color: rgb(64, 92, 116);*/
}

.button.outline::before {
    
    top: 0;
    left: 0;
    border-bottom-color: transparent;
    border-right-color: transparent;
    border-top-color:white;
    border-left-color:white;
}

.button.outline::after{
    bottom: 0;
    right: 0;
    border-top-color: transparent;
    border-left-color: transparent;
    border-bottom-color: white;
    border-right-color:white;
}
.button.outline:hover{
    color:var(--mycolorspaceblue);
}
.button.outline:hover:after, .button.outline:hover:before {
width: 100%;
height: 100%;
}
.hero-title{
    position: absolute;
    color: white;
    text-align: left;
    padding-top: 480px;
    margin: 3.5rem;
    font-family:var(--fontCormorant);
}
span .spanMP{
    color: var(--mycolorspaceblue);
    text-align: center;
    font-family:var(--fontCormorant);
}
#myVideo {
    position: fixed;
    z-index: -1;
    right: 0;
    bottom: 0;
    min-width: 100%; 
    min-height: 30%;
    filter: brightness(85%);
}

.information{
    padding: 3rem 0;
    background:white;
    width: 100%;
    margin-top: 45rem;
    display: grid;
    justify-content: center;
    grid-template-columns: repeat(3, 1fr);
    column-gap: 2rem;
}

.information1{
    padding: 1rem 2rem;
    /*height: 300px;
    width: 0%;*/
    margin: 5% 8%;
    background: white;
}

.information2 img{
    /*padding: 1rem 2rem;
    /*height: 300px;
    width: 30%;*/
    margin: 5% 8%;
}

.information2:hover img{
    opacity: 0.4;
}

.information3 img{
   /* padding: 1rem 2rem;
    /*height: 300px;
    width: 30%;*/
    margin: 5% 8%;
}
.information3:hover img{
    opacity: 0.4;
}

.button.more{
    font-family: var(--fontBebas);
    background-color: black;
    transition: background-color 0.5s ease-out;
}

.button.more:hover{
    background-color: var(--mycolorspaceblue);
}

.bar{
    width: 60px;
    height: 5px;
    position: relative;
    bottom: 3%;
    background: var(--mycolorspaceblue);
}

wh {
    font-family: var(--fontBebas);
    font-size: 400%;
    color: white;
}

g{
    color: var(--mycolorspaceblue);
}
@media (max-width:768px){
    .information{
        display: grid;
        justify-content: center;
        grid-template-columns: repeat(2,1fr);
        column-gap: 1rem;
    }
    .information2 img{
        position: relative;
        right: 3rem;
        top: 3.4rem;
    } 
    .information3 img{
        position: relative;
        left: 10rem;
    }
  
}

.informationVideo{
    position: relative;
    margin-bottom: 2%;
    left: 0.1%;
}

.contentVideo{
    background: black;
    padding: 90px;
    text-align: center;

}

.videoBorder{
    position: relative;    
    overflow: hidden;
}

.videoBorder video {
    max-width: 100%;
    height: auto;
    border: 5px solid var(--mycolorspaceblue);
}
@media (max-width:768px){
    .videoBorder{
        left: 50%;
        display: block;
        resize: vertical;
        margin-top: 4rem;
        width: 100%;
        max-height: 100%;
        transform: translate(-50%, -5%);
    }
}
.contentBlog{
    background: var(--mycolorspaceblue);
    padding: 3rem 0;
    width: 100%;
    display: grid;
    justify-content: center;
    grid-template-columns: repeat(2, 1fr);
    column-gap: 1px;
}

.people{
    position: relative;
    top: 15%;
    margin: 3% 15%;
}

.people:hover img{
    cursor: pointer;
    opacity: 0.4;
}

.informationBlog{
    text-align: center;
}

.button.more2{
    font-family: var(--fontBebas);
    background-color: black;
    transition: background-color 0.5s ease-out;
    position: relative;
    top: 5%;
    left: 34%;
}

.button.more2:hover{
    background-color: white;
    color: black;
}

.informationBlog bi{
    
    font-family: var(--fontMontserrat);
    font-size: 200%;
    font-weight:200;
}

bm {
    font-family: var(--fontMontserrat);
    font-size: 100%;
    font-weight: 700;

}

bt {
    font-family: var(--fontMontserrat);
    font-size: 200%;
    font-weight: 700;
}

.chatImage{
    padding: 2% 35%;
}
@media(max-width:768px){
    .contentBlog{
        display: grid;
        justify-content: center;
        grid-template-columns: repeat(1, 1fr);
        column-gap: 1px;
    }
    .informationBlog{
        position:relative;

        top:3rem;
    }
}

/* -----------FOOTER--------------*/
.footer-bs {
    background-color: var(--mycolorgreydark);
    height: 30%;
	padding: 1rem;
	color: rgba(255,255,255,1.00);
	border-top-left-radius: 0px;
}
.row{
    box-sizing: border-box;
    display: grid;
    grid-template-columns:repeat(3, 1fr);
}

.footer-brand img{
    float: initial;
    padding: 3px 0;
    margin-top:5px;   
}
.footer-bs .footer-brand, .footer-bs .footer-nav, .footer-bs .footer-social{
    padding:10px 25px; 
    text-align:center;
    font-size: 20px;
}
.footer-bs .footer-nav, .footer-bs .footer-social {
     border-color: transparent; }
.footer-bs .footer-brand h2 {
     margin:0px 0px 10px;
     }
.footer-bs .footer-brand p {
     font-size:12px; 
     color:var(--mycolorgrey); 
    }

.footer-bs .footer-nav ul.pages {
     list-style:none; 
     padding:0px; }
.footer-bs .footer-nav ul.pages li {
     padding:5px 0px;}
.footer-bs .footer-nav ul.pages a {
     color:white;
  
       text-transform:uppercase;
     }
.footer-bs .footer-nav ul.pages a:hover {
     color:var(--mycolorwhitelowopacity);
      text-decoration:none;
     }

.footer-bs .footer-nav ul.list { 
    list-style:none; 
    padding:0px; }
.footer-bs .footer-nav ul.list li {
     padding:10px 0px;}
.footer-bs .footer-nav ul.list a {
     color:rgba(255,255,255,0.80);
     }
.footer-bs .footer-nav ul.list a:hover {
     color:rgba(255,255,255,0.60);
     text-decoration:none; }

.footer-bs .footer-social ul {
     list-style:none;
     padding:3px; }
.footer-bs .footer-social li {
     padding:15px 4px;
    }
.footer-bs .footer-social a { 
    font-size: 25px;
    color:rgba(255,255,255,1.00);
}
.footer-bs .footer-social a:hover { 
    color:var(--mycolorwhitelowopacity);
     text-decoration:none; 
    }


    @media (min-width: 768px) {
        .footer-bs .footer-nav, .footer-bs .footer-social {
             border-left:inset 2px var(--mycolorwhitelowopacity);
        }
    }
