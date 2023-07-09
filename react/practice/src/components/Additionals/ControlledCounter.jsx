import { useState } from "react";
import React from "react";
const ControlledCounter = () => 
{

    const [inputValue, setInputValue] = useState('');
    
    const handleChange = (event) => {
        setInputValue(event.target.value);
    };
    return(
        <div>
            <label htmlFor="inputField">Enter a value:</label>
            <input type = "text"
            id = "inputField"
            value = {inputValue}
            onChange={handleChange}
            />
            <p>you entered: {inputValue}
            </p>
        </div>
    )
};

export default ControlledCounter;