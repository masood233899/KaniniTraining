import "./App.css";
import BoundedComponent from "./components/Additionals/BoundedComponent";
import ControlledCounter from "./components/Additionals/ControlledCounter";
import Footer from "./components/Additionals/Footer";
import Header from "./components/Additionals/Header";
import HooksExample from "./components/Additionals/HooksExample";
import HooksMessage from "./components/Additionals/HooksMessage";
import ModuleHandling from "./components/Additionals/ModuleHandling";
import Practice from "./components/practice";


// function HeaderComp() {
//   return <h1>Hello</h1>;
// }
function App() {
  let title = "new page";

  return (
    <div>
      <p>{title}</p>
      {/* <HeaderComp />
      <ControlledCounter></ControlledCounter>
      <BoundedComponent></BoundedComponent> */}
      {/* <ModuleHandling/>  */}

      {/* <Header/>
      <HooksExample/>
      <HooksMessage/>
      <Footer/> */}
      <Practice model = "mj"/>
      
    </div>
  );
}

export default App;
