import React from "react";
import { BrowserRouter, Routes, Route, Link, useNavigate} from "react-router-dom";

import { useState } from "react";
import Home from './navigation/Home.jsx';
import Contact from "./navigation/Contact";
import About from "./navigation/About";
import User from "./navigation/User";
import CategoryCrud from "./Student/CategoryCrud.jsx";
function App() {
  return (
    <BrowserRouter>
    <CategoryCrud/>
    {/* <MainApp/> */}
    
     </BrowserRouter> 
  );
};

const MainApp = () => {
    const [id, setid] = useState('');
    const navigate = useNavigate();

    const sendId = (event) => {
      setid(event.target.value);
    };

    const handleNavigation = () => {
      navigate(`/user/${id}`);
    }

    return (
      <div>
        <input type="text" value={id} onChange={navigate}></input>
        <Routes>
      <Route exact path="" element={<Home />} />
      <Route exact path="about" element={<About />} />
      <Route exact path="contact" element={<Contact />} />
      <Route exact path="/user/:id" element={<User/>} />
    </Routes>
  <div>
    <nav>
      <ul>
        <li>
          <Link to="/">Home</Link>
        </li>
        <li>
          <Link to="about">About</Link>
        </li>
        <li>
          <Link to="contact">Contact</Link>
        </li>
      </ul>
    </nav>

    <hr />
    
  </div></div>
      
    )

}

export default App;
