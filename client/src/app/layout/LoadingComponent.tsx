import {Backdrop, Box,Typography } from "@mui/material";
import CircularProgress from '@mui/material/CircularProgress';
interface Props {
    message?: string;
}

export default function LoadingComponent({message = 'Loading...'}: Props){
    return (
        <Backdrop open={true} invisible={true}>
            <Box display='flex' justifyContent='center' alignItems='center' height='100vh'>
                <CircularProgress color='secondary'/>
                <Typography variant='h4' sx={{justifyContent: 'center', position: 'fixed', top: '60%'}}>{message}</Typography>
            </Box>
        </Backdrop>
    )
}