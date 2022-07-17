import { Box,Typography } from "@mui/material";
import Slider from "react-slick";

export default function HomePage(){
    const settings = {
        dots: true,
        infinite: true,
        speed: 500,
        slidesToShow: 1,
        slidesToScroll: 1
      };
    return (
        // <Typography variant='h2' sx={{textAlign:'center'}} > 
        // Welcome to ET-AR - Your solution to everything related to cars!

        // </Typography>
        <>
        <Slider {...settings}>
            <div>
                <img src="/images/parts.jpg" alt="banner" style={{display:'block', width: '100%', height:'500px'}}/>
            </div>
            <div>
                <img src="/images/rent.jpg" alt="banner" style={{display:'block', width: '100%', maxHeight:'500px'}}/>
            </div>
            <div>
                <img src="/images/buy.jpg" alt="banner" style={{display:'block', width: '100%', maxHeight:'500px'}}/>
            </div>
        </Slider>
        <Box display='flex' justifyContent='center' sx={{p:4}}>
            <Typography variant='h2'>
                Welcome to ET-AR - Your solution to everything
            </Typography>
        </Box>
        </>
    )
}