import AwesomeSlider from 'react-awesome-slider';
import 'react-awesome-slider/dist/styles.css';
import './Slider.css'

const Slider = () =>(
    <AwesomeSlider className="slider">
        <div data-src="/products/1.jpg"/>
        <div data-src="/products/2.jpg" />
        <div data-src="/products/3.jpg" />
        <div data-src="/products/4.jpg" />
        <div data-src="/products/5.jpg" />
    </AwesomeSlider>
);

export default Slider;