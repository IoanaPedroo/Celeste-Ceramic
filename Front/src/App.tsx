import React from 'react';
import './App.css';
import { BrowserRouter as Router, Routes, Route} from "react-router-dom";
import Footer from "./Components/Footer";
import Navbar from "./Components/Navbar"
import PageCategories from "./pages/productPages/Page-Categories";
import ContactUs from "./pages/contactPage/Contact-us";
import Register from "./pages/authentificationPages/Register";
import SignUp from "./pages/authentificationPages/Sign-up";
import AboutUs from "./Components/About-us";
import Product from "./pages/productPages/Product";
import Slider from "./Components/Slider";







function App() {

  return (
    <div className="App">
      <Navbar/>
        <Router>
            <Routes>
                <Route path="/products"  element={(<PageCategories/>)}/>
                <Route path="/about" element={(<AboutUs/>)}/>
                <Route path="/contact" element={(<ContactUs/>)}/>
                <Route path="/sign-up" element={(<SignUp/>)}/>
                <Route path="/register" element={(<Register/>)}/>
                <Route path="/products/:id" element={(<Product/>)}/>
                <Route path="/" element={(<Slider/>)}/>
            </Routes>
        </Router>

      <Footer/>
    </div>
  );
}

export default App;
