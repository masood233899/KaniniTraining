import React from "react";
import "./Button.css";
const Button = ({onClick, text}) => {
    return <button id="btn" onClick = {onClick}>{text}</button>
}

export default Button;