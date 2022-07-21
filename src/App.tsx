import React from 'react';
import './App.css';
import { BrowserRouter as Router, Routes, Route} from "react-router-dom";

import Footer from "./Components/Footer";
import Navbar from "./Components/Navbar";
import Slider from "./Components/Slider";
import PageCategories from "./Components/Page-Categories";
import ContactUs from "./Components/Contact-us";


function App() {
  return (
    <div className="App">
      <Navbar/>
        <Router>
            <Routes>
                <Route path="/category"  element={(<PageCategories/>)}/>
                <Route path="/contact" element={(<ContactUs/>)}/>
                <Route path="/sign-up" />
                <Route path="/" element={(<Slider/>)}/>
            </Routes>
        </Router>

      <Footer/>
    </div>
  );
}

export default App;
