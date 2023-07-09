// function func() {
//     let x='a', y=10;
//     document.getElementById("para").innerHTML = x+y;
//     {
        
//         document.getElementById("para1").innerHTML = x+y;
//     }
//     prompt('hi')
// }


// function f1(x,y) {
//     let z=100;
//     document.getElementById("para3").innerHTML = x-z+y**y;
// }


function f2(x,y) {
    var ans = x+y;
    return ans;
    // document.getElementById("para4").innerHTML=ans;
    // document.getElementById("para3").innerHTML = x-z+y**y;
}

function f4()
{
    stud={rno:100, name:'AAA', address:'13, dfgh'}
    document.getElementById("para5").innerHTML = stud.rno + ' ' +stud.name+stud.address;

    stud.rno = '123'
    document.getElementById("para5").innerHTML = stud.rno + ' ' +stud.name+stud.address;
}

