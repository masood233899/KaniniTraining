function validatename() {
    var name = document.getElementById('name');
    var pattern = /^[A-Za-z\s]*$/;
    if((name.value == "") || (!name.value.match(pattern)))
    {
        name.classList.remove('valid');
        name.classList.add('invalid');
        document.getElementById('result').innerHTML = 'Enter valid credentials';
        name.focus();
        return false;
    }
    else
    {
        name.classList.remove('invalid');
        name.classList.remove('valid');
       
    }
}

function validateph() {
    var ph = document.getElementById('ph');
    var pattern = /^\(?(\d{3})\)?[- ]?(\d{3})[- ]?(\d{4})$/;
    if((!ph.value.match(pattern)))
    {
        ph.classList.remove('valid');
        ph.classList.add('invalid');
        
        document.getElementById('result').innerHTML ='Enter valid credentials';
        ph.focus();
        return false;
    }
    else 
    {
        ph.classList.remove('invalid');
        ph.classList.add('valid');
        
    }

}


function validateemail() {
    var email = document.getElementById('email');
    var pattern = /^[a-zA-Z0-9.!#$%&'*+/=?^_`{|}~-]+@[a-zA-Z0-9-]+(?:\.[a-zA-Z0-9-]+)*$/;
    if(!email.value.match(pattern))
    {
        email.classList.remove('valid');
        email.classList.add('invalid');
       
        document.getElementById('result').innerHTML ='Enter valid credentials';
        email.focus();
        return false;
    }
    else 
    {
        email.classList.remove('invalid');
        email.classList.add('valid');
        
    }
}



function validateadd() {
    var add = document.getElementById('add');
    
    if((add.value == ""))
    {
        add.classList.remove('valid');
        add.classList.add('invalid');
        
        document.getElementById('result').innerHTML ='Enter valid credentials';
        add.focus();
        return false;
    }
    else 
    {
        add.classList.remove('invalid');
        add.classList.add('valid');
        
    }
}


  







var prices = {
    option1: 799,
    option2: 899,
    option3: 1199,
    option4: 299,
    option5: 999
}

function costCalculation() {
    
    if(validatename() ==null && validateph()==null && validateadd()==null && validateemail()==null)
    {
        var opt1 = document.getElementById('opt1').checked;
        var opt2 = document.getElementById('opt2').checked;
        var opt3 = document.getElementById('opt3').checked;
        var opt4 = document.getElementById('opt4').checked;
        var opt5 = document.getElementById('opt5').checked;
        
        var total = 0;
    
        if(opt1 || opt2|| opt3 || opt4 || opt5)
        {
            if(opt1)
            {
                total += prices.option1;
            }
            if(opt2)
            {
                total += prices.option2;
            }
            if(opt3)
            {
                total += prices.option3;
            }
            if(opt4)
            {
                total += prices.option4;
            }
            if(opt5)
            {
                total += prices.option5;
            }
    
            if(total>2000)
            {
                dis = total*0.8;
                document.getElementById('result').innerHTML='Order has been placed successfully. You are requested to pay Rs.'+Math.round(dis)+ 'on the delivery';
            }
            else {
                document.getElementById('result').innerHTML = 'Order has been placed successfully. You are requested to pay Rs.'+Math.round(total)+ 'on the delivery';
            }
        }
        else {
            document.getElementById('result').innerHTML = 'No Selection has been made';
        }
    }

   
    
}

