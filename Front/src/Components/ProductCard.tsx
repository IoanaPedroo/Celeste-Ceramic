import { Avatar, Button, Card, CardActions, CardContent, CardMedia, Grid, Typography } from "@mui/material"
import { Link } from "react-router-dom"
import { isNamedExportBindings } from "typescript"
import imageUrl from "../products/one.jpg"


const ProductCard=(props:any)=>{
    console.log(props)
    return (
        <>
            <Card sx={{ maxWidth: 345 }}>
                <CardMedia
                    component="img"
                    height="150"
                    image={props.image}
                    alt="iguana"
                />
                <CardContent>
                    <Typography gutterBottom variant="h5" component="div">
                        {props.name} {props.price} {props.currency}
                    </Typography>
                    <Typography variant="body2" color="text.secondary">
                        {props.description}
                    </Typography>
                </CardContent>
                <CardActions>
                    <Button size="small">Add to cart</Button>
                    <Button component ={Link} to={`/catalog/${props.name}`}size="small">Learn More</Button>
                </CardActions>
            </Card>

        </>

    )

}
export default ProductCard;