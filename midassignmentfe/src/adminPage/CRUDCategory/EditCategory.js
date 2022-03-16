import React from "react";
import { useParams } from "react-router-dom"; 
import { useState } from "react";
import axios from "axios";
import { TextField } from "@mui/material";
import { Button } from "@mui/material";
const EditCategory = () =>{
    const [category, setCategory] = useState({
        categoryName:''
      })
      const HandleInputChange=(evt)=>{
        setCategory({
          ...category,
          [evt.target.name]: evt.target.value
        })
      }
      const readParams = useParams()
      const HandleOnSubmit = evt => {
        evt.preventDefault();
        axios.put(`https://localhost:7162/edit-category?id=${readParams.id}`, category)
        .then(response => {
          console.log(response)
        });
      }
    
      return (
        <div >
          <form >
            <TextField id="outlined-basic" 
            label="Category" 
            variant="outlined"
            value={category.categoryName} 
            name="categoryName"
            onChange={HandleInputChange}
            />
            <Button onClick={HandleOnSubmit} variant="contained" style={{ margin: '20px', display: 'block' }}>Submit</Button>
          </form>
        </div>
      )
}

export default EditCategory;