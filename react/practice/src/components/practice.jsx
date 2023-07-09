import React from "react";

const Practice  = (props) => {
    var greeting = <h1>Gwotham</h1>
    var g = <h1>hello</h1>
    var m = <h1>props.model</h1>
    if(false) {
        greeting = <h1>Gowtham</h1>
    }
    return (
        <div>
            <h1>{props.model}</h1>
            {m}
            {greeting}
            {g}
        </div>
    )
}
export default Practice;
