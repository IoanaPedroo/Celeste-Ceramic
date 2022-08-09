import { Avatar, Button, Card, CardActions, CardContent, CardMedia, Grid, Typography } from "@mui/material"
import { Props } from "./ProductList"

export default function ProductCard({pictureUrl, productName, price, currency, description}:Props){
    return (
    <>
    <Card sx={{ maxWidth: 345 }}>
        <CardMedia
        component="img"
        height="150"
        image={pictureUrl}
        alt="green iguana"
        />
        <CardContent>
        <Typography gutterBottom variant="h5" component="div">
            {productName} {price} {currency} 
        </Typography>
        <Typography variant="body2" color="text.secondary">
            {description}
        </Typography>
        </CardContent>
        <CardActions>
        <Button size="small">Add to cart</Button>
        <Button size="small">Learn More</Button>
        </CardActions>
    </Card>

    </>
         
    )
 
}