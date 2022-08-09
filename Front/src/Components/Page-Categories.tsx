import {Avatar, List, ListItem, ListItemAvatar, ListItemText} from "@mui/material";
import React from "react";
import ProductCard from "./ProductCard";
import './ProductCard.css'
import './Categories.css'


export interface Props {

    productName? : string
    price? : number
    currency? : string
    description? : string
    pictureUrl : string

}

const Categories = () => {
    const products = [
        {productName: 'Cercei stravezii', price: 50, currency: 'lei', description: "handmade pottery", pictureUrl : "/products/five.jpg"},
        {productName: 'Vaza Ming', price: 50, currency: 'lei', description: "handmade pottery", pictureUrl :  "/products/four.jpg"},
        {productName: 'Cana cherry', price: 50, currency: 'lei',description: "handmade pottery", pictureUrl :  "/products/three.jpg"},
        {productName: 'Cana Toucan', price: 50, currency: 'lei', description: "handmade pottery", pictureUrl :  "/products/two.jpg"},
        {productName: 'Vaza Roma', price: 50, currency: 'lei', description: "handmade pottery", pictureUrl :  "/products/one.jpg"},
        {productName: 'Vaza Roma', price: 50, currency: 'lei', description: "handmade pottery", pictureUrl :  "/products/one.jpg"},
    ];
    return(
        <div>
            <h1>Products Page</h1>
            <List className="grid">

                {products.map((product, index) => (
                    <div className="element">
                        <ListItem key={index} />
                        <ProductCard pictureUrl = {product.pictureUrl} productName = {product.productName}
                                     price = {product.price} currency = {product.currency} description = {product.description}/>
                    </div>
                ))}
            </List>
        </div>

    )
}
export default Categories;