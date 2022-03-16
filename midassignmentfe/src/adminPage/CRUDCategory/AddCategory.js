import React, { useState, useEffect } from "react";
import axios from "axios";
import Button from '@mui/material/Button';
import TextField from '@mui/material/TextField';
const AddCategory = () => {

  const [category, setCategory] = useState({
    categoryName:''
  })
  const HandleInputChange=(evt)=>{
    setCategory({
      ...category,
      [evt.target.name]: evt.target.value
    })
  }
  const HandleOnSubmit = evt => {
    evt.preventDefault();
    axios.post('https://localhost:7162/add-new-category', category)
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

export default AddCategory