import React from "react";
const BookList = ()=>{

    const [books, setBooks] = useState([]);
    useEffect(() => {
        axios({
            method: 'GET',
            url: `https://localhost:7162/get-all-book`
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
                            <TableCell>Book Name</TableCell>
                            <TableCell align="left">Action</TableCell>
                        </TableRow>
                    </TableHead>
                    <TableBody>
                        {books.map((book) => (
                            <TableRow >
                                <TableCell align="left">{book.categoryName}</TableCell>
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
export default  BookList