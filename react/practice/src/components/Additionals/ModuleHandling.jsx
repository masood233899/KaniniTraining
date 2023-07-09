import React from "react";
import Button from "./Button";

const ModuleHandling =() =>{
    const handleClick = () => {
        console.log("Button Clicked");
    }

    const showAlert = ()=> {
        alert("Button Clicked");
    }

    return(
        <div>
            <Button onClick={handleClick} text="Click..."></Button>
            <Button onClick={showAlert} text="Click..."></Button>

        </div>
    );
}

export default ModuleHandling;