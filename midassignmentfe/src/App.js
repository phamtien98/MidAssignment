
import './App.css';
import LoginPageUser from './userPage/LoginPage/LoginPageUser';
import HomePageUser from './userPage/HomePage/HomePageUser';
import {
  BrowserRouter,
  Routes,
  Route,
} from "react-router-dom";
import LoginPageAdmin from './adminPage/LoginPage/loginPageAdmin';
import AddCategory from './adminPage/CRUDCategory/AddCategory';
import HomePageAdmin from './adminPage/HomePageAdmin/HomePageAdmin';
import EditCategory from './adminPage/CRUDCategory/EditCategory';
import DeleteCategory from './adminPage/CRUDCategory/DeleteCategory';

function App() {

  return (
    <BrowserRouter>
    <Routes>
      <Route path="/" element={<HomePageUser />}> </Route>
      <Route path="/admin" element={<LoginPageAdmin />}> </Route>
      <Route path="/admin/home" element={<HomePageAdmin />}> </Route>
      <Route path="/admin/add" element={<AddCategory />}> </Route>
      <Route path="/admin/edit/:id" element={<EditCategory />}> </Route>
      <Route path="/admin/delete/:id" element={<DeleteCategory />}> </Route>
    </Routes>
  </BrowserRouter>
  
  );
}

export default App;
