function fun3()
{
    var username=document.getElementById("username").value;
    var pass=document.getElementById("password").value;
    var username_pattern="gamify";
    var password1="1234";
    if(username==username_pattern && pass==password1)
    {
        document.getElementById("username").style.borderColor="white";
        document.getElementById("password").style.borderColor="white";
        document.getElementById("link").href="home1.html"; 
        fun3();

    }
    else{
        document.getElementById("username").style.borderColor="red";
        document.getElementById("password").style.borderColor="red";


    }

}