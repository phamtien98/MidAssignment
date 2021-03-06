import React from "react";
import { Link } from "react-router-dom";
import Table from '@mui/material/Table';
import TableBody from '@mui/material/TableBody';
import TableCell from '@mui/material/TableCell';
import TableContainer from '@mui/material/TableContainer';
import TableHead from '@mui/material/TableHead';
import TableRow from '@mui/material/TableRow';
import Paper from '@mui/material/Paper';
import { useState, useEffect } from "react";
import axios from "axios";

const HomePageAdmin = () => {

    const [categories, setCategories] = useState([]);
    useEffect(() => {
        axios({
            method: 'GET',
            url: `https://localhost:7162/get-all-category`
        }).then(response => {
            console.log(response)
            setCategories(response.data)
        })

    }, [])
    return (
        <div>
         <Link className="link-button" style={{ backgroundColor: '#6633FF' }} to={"/admin/add"}>Add</Link>
            <TableContainer component={Paper}>
                <Table sx={{ minWidth: 650 }} aria-label="simple table">
                    <TableHead>
                        <TableRow>
                            <TableCell>Category</TableCell>
                            <TableCell align="left">Action</TableCell>
                        </TableRow>
                    </TableHead>
                    <TableBody>
                        {categories.map((category) => (
                            <TableRow key={category.categoryId} >
                                <TableCell align="left">{category.categoryName}</TableCell>
                                <TableCell align="left">
                                    <Link className="link-button" style={{ backgroundColor: '#6633FF' }} to={`/admin/edit/${category.categoryId}`}>Edit</Link>
                                    <Link className="link-button" style={{ backgroundColor: '#FF0000' }} to={`/admin/delete/${category.categoryId}`} >Remove</Link>
                                </TableCell>
                            </TableRow>
                        ))}
                    </TableBody>
                </Table>
            </TableContainer>
        </div>
    )
}


export default HomePageAdmin