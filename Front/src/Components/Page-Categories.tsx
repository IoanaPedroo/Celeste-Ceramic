import {Avatar, List, ListItem, ListItemAvatar, ListItemText} from "@mui/material";
import React, { useEffect, useState } from "react";
import ProductCard from "./ProductCard";
import './ProductCard.css'
import './Categories.css'


// export interface Props {

//     productName? : string
//     price? : number
//     currency? : string
//     description? : string
//     pictureUrl : string

// }

const Categories = () => {
    // const products = [
    //     {productName: 'Cercei stravezii', price: 50, currency: 'lei', description: "handmade pottery", pictureUrl : "/products/five.jpg"},
    //     {productName: 'Vaza Ming', price: 50, currency: 'lei', description: "handmade pottery", pictureUrl :  "/products/four.jpg"},
    //     {productName: 'Cana cherry', price: 50, currency: 'lei',description: "handmade pottery", pictureUrl :  "/products/three.jpg"},
    //     {productName: 'Cana Toucan', price: 50, currency: 'lei', description: "handmade pottery", pictureUrl :  "/products/two.jpg"},
    //     {productName: 'Vaza Roma', price: 50, currency: 'lei', description: "handmade pottery", pictureUrl :  "/products/one.jpg"},
    //     {productName: 'Vaza Roma', price: 50, currency: 'lei', description: "handmade pottery", pictureUrl :  "/products/one.jpg"},
    // ];

    let [allProducts, GetAllProducts] = useState([{id: "", name: "", description: "", price: "", currency: "", discount: "", category: "", productinventory: "", image: "" }])
    useEffect(()=>{
        fetch(`https://localhost:7202/product/getallproducts`, 
        { method: "GET",
    headers: {'Access-Control-Allow-Origin': 'http://localhost:3000'}
    })
        .then(response=>response.json())
        .then((response) => {GetAllProducts(response)})
    }, [])
    console.log("yoyoyyo")
    console.log(allProducts)
    return(
        <div>
            <h1>Products Page</h1>
            <List className="grid">

                {allProducts.map((product) => (
                    <div className="element">
                        <ListItem key={product.id} />
                        <ProductCard pictureUrl = {product.image} productName = {product.name}
                                     price = {product.price} currency = {product.currency} description = {product.description}/>
                    </div>
                ))}
            </List>
        </div>

    )
}
export default Categories;