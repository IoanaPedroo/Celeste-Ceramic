import React from 'react';
import logo from './logo.svg';
import './App.css';
import { listenerCount } from 'process';
import {Avatar, List, ListItem, ListItemAvatar, ListItemText} from "@mui/material";


const products = [
{productName: 'Cercei stravezii', price: 50, currency: 'lei', description: "handmade pottery", pictureUrl : "/products/five.jpg"},
{productName: 'Vaza Ming', price: 50, currency: 'lei', description: "handmade pottery", pictureUrl :  "/products/four.jpg"},
{productName: 'Cana cherry', price: 50, currency: 'lei',description: "handmade pottery", pictureUrl :  "/products/three.jpg"},
{productName: 'Cana Toucan', price: 50, currency: 'lei', description: "handmade pottery", pictureUrl :  "/products/two.jpg"},
{productName: 'Vaza Roma', price: 50, currency: 'lei', description: "handmade pottery", pictureUrl :  "/products/one.jpg"},
]

function App() {
  return (
    <div className="App">
      <h1>Products Page</h1>
      <List>
        {products.map((product, index) => (
          <ListItem key={index}>
          <ListItemAvatar>
          <Avatar src={product.pictureUrl}/>
          <ListItemText>{product.productName} - {product.price} {product.currency} - {product.description} <br></br><button>Add to cart</button></ListItemText>
          </ListItemAvatar>
          </ListItem>
        ))}
      </List>
    </div>
  );
}

export default App;
