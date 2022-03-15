
import './App.css';
import LoginPageUser from './userPage/LoginPage/LoginPageUser';
import HomePageUser from './userPage/HomePage/HomePageUser';
import {
  BrowserRouter,
  Routes,
  Route,
} from "react-router-dom";
import LoginPageAdmin from './adminPage/LoginPage/loginPageAdmin';
import AddCategory from './adminPage/AddCategory/AddCategory';

function App() {

  return (
    <BrowserRouter>
    <Routes>
      <Route path="/" element={<HomePageUser />}> </Route>
      <Route path="/admin" element={<LoginPageAdmin />}> </Route>
      <Route path="/admin/add" element={<AddCategory />}> </Route>
    </Routes>
  </BrowserRouter>
  
  );
}

export default App;
