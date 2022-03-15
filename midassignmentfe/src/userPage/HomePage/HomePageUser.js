import axios from "axios";
import React, { useEffect, useState } from "react";
const HomePageUser=()=>{
    const [test,setTest] = useState([]);
    useEffect(()=>{
        axios({
            method:'GET',
            url: `https://localhost:7162/get-all-category`
        }).then(response =>{
            console.log(response)
            setTest(response.data)
        })

    },[])
    return (
 <div>
     Test
</div>
    )
}

export default HomePageUser