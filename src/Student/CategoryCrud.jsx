import React, {useEffect, useState} from "react";
import axios from "axios";

const CategoryCrud = () => {
    const [categories, setCategory] = useState([]);
    const basepath = "https://localhost:7199"

    const newCategory = {
        "catId":3,
        "catName":"other"
    };
    const updatedcategory = {
        "catName":"other"
    }
    useEffect(() => {
        fetchCategories();
    }, [categories]);

    const fetchCategories = async () => {
        try{
            const response = await axios.get(basepath + `/api/Categories`);
            setCategory(response.data);
        }
        catch(error) {
            console.error(error);
        }
    }

    const createCategory = async () => {
        try {
             const response = await axios.post(basepath + `/api/Categories`,newCategory);
             setCategory([...categories,response.data]);
        }
        catch(error){
            console.error(error);

        }
    }

    const updateCategory = async (id) => {
        try{
            console.log(id);
            const response = await axios.put (basepath + `/api/Categories/${id}`, updatedcategory);
            const updates =categories.map((category) =>{
                if(category.catId === id){
                    return response.data;
                }
                return category;
            });
            setCategory(updates);
        }
        catch(error) {
            console.error(error);
        }
    }

    const deleteCategory = async(id) => {
        try{
            console.log(id);
            await axios.delete(basepath + `/api/Categories/${id}`);
            fetchCategories();
        }
        catch (error) {
            console.error(error);

        }
    };
    return (
        <div>
            <h1>Categories</h1>
            <button onClick={createCategory}>Create a Category</button>
            <ul>
                {categories.map((category) => (
                    <li key={category.catId}>
                        <span>Id: {category.catId}</span>&nbsp; &nbsp; &nbsp;
                        <span>Name: {category.catName}</span>&nbsp; &nbsp; &nbsp;
                        <button onClick={()=> updateCategory(category.catId)}>Update</button>
                        <button onClick={()=> deleteCategory(category.catId)}>Delete</button>
                    </li>
                ))}
            </ul>
        </div>
    )
}

export default CategoryCrud;