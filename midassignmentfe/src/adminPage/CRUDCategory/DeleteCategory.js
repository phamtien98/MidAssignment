import React from "react";
import { useParams } from "react-router-dom";
import { Button } from "@mui/material";
import axios from "axios";
import { Link } from "react-router-dom";
const DeleteCategory = ()=>{
    const readParams = useParams()
    const HandleOnSubmit = evt => {
      evt.preventDefault();
      axios.delete(`https://localhost:7162/delete-category?id=${readParams.id}`)
      .then(response => {
        console.log(response)
      });
    }
    return (
        <div>
            <form>
            <label>Are u sure want to delete</label>
            <Button onClick={HandleOnSubmit} variant="contained" style={{ margin: '20px', display: 'block' }}>Submit</Button>
            <Link to={"/admin/home"}> Back To List
            </Link>
            </form>
        </div>
    )
}

export default DeleteCategory;