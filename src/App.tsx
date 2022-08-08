import React from 'react';
import './App.css';
import { BrowserRouter as Router, Routes, Route} from "react-router-dom";
import Footer from "./Components/Footer";
import Navbar from "./Components/Navbar";
import Slider from "./Components/Slider";
import PageCategories from "./Components/Page-Categories";
import ContactUs from "./Components/Contact-us";
import Register from "./Components/Register";
import SignUp from "./Components/Sign-up";
import AboutUs from "./Components/About-us";
import Dashboard from './Components/Dashboard';





function App() {

  return (
    <div className="App">
      <Navbar/>
        <Router>
            <Routes>
                <Route path="/category"  element={(<PageCategories/>)}/>
                <Route path="/about" element={(<AboutUs/>)}/>
                <Route path="/contact" element={(<ContactUs/>)}/>
                <Route path="/sign-up" element={(<SignUp/>)}/>
                <Route path="/register" element={(<Register/>)}/>
                <Route path="/" element={(<Slider/>)}/>
                <Route path="/dashboard" element={(<Dashboard/>)}/>
            </Routes>
        </Router>

      <Footer/>
    </div>
  );
}

export default App;
