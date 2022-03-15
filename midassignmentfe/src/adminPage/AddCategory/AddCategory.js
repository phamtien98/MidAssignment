import React, { useState,useEffect } from "react";
import axios from "axios";

const AddCategory = () => {

  const [category,setCategory] = useState({
    categoryName: ''
  })

  useEffect(() => {
    // POST request using axios inside useEffect React hook
    axios.post('https://localhost:7162/add-new-category', category)
        .then(response => {
          console.log(response)
        });

// empty dependency array means this effect will only run once (like componentDidMount in classes)
}, []);

  return (
    <div>
      ok
    </div>
  )
}

export default AddCategory