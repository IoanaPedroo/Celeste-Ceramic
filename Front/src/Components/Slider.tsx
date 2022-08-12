import AwesomeSlider from 'react-awesome-slider';
import 'react-awesome-slider/dist/styles.css';
import './Slider.css'
import img from "/public/images/1.jpg"

const Slider = () =>(
    <AwesomeSlider className="slider">
        <div data-src="/images/1.jpg"/>
        <div data-src="/images/2.jpg" />
        <div data-src="/images/3.jpg" />
        <div data-src="/images/4.jpg" />
        <div data-src="/images/5.jpg" />
    </AwesomeSlider>
);

export default Slider;