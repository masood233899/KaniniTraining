function f1()
{
    numbers = [100, 200, 300];
    alert(numbers[2]);
    numbers[3] = 500;
    alert(numbers[3]);
    
}

function f2()
{
    nums = new Array(100, 200, 300);
    nums[2] = 500;
    nums[10] = 1000;
    alert(nums[1]);
    alert(nums[2]);
    alert(nums[7]);
    alert(nums[10]);
    alert(nums);
}

function f3()
{
    const numbs = [1, 2, 3, 4];
    alert(numbs)
    
    numbs[2]=12
    alert(numbs[2])
}

function regex() {
    let pattern = ' w3sch ools';
    let input = 'o';
    let n = pattern.search(input)

    if (n==-1)
    {
        // alert('pattern not matched')
        document.getElementById('para2').style.display = "block";
        document.getElementById('para2').innerHTML = 'pattern not matched';
    }
    else
    {  
        document.getElementById('para2').style.display = "block";
        document.getElementById('para2').innerHTML = pattern.search(input);
    }
}

function match() {
    // let pattern = /(x|y|z)/
    // let input = "xcm";          //pattern matches for input 'xcm'
    // alert(input.match(pattern))

    // let pattern = /dcc+/
    // let input = "dccm";
    // alert(input.match(pattern))

    let pattern = /[A-Z]?+[a-z]?+[0-9]?+/
    let input = "aB0";
    

    if(input.match(pattern ) ==null) //value of input.match(pattern) is null if no match and the output is the matched pattern if pattern is matched
    {
        alert("not found")
    }
    else
    {
        alert("found")
    }
}