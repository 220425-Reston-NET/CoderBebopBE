import React from 'react';
import logo from './logo.svg';
import './App.css';
import { Route, Routes } from 'react-router-dom';
import Welcome from './routes/welcome/Welcome';
import Nav from './shared/Nav';
import Mainmenu from './routes/mainmenu/Mainmenu';
import CreateCustomer from './routes/createcustomer/CreateCustomer';

function App() {
  return (
    <>
    <Nav/>
    <Routes>
      <Route path='/' element={<Welcome/>}/>
      <Route path='/mainmenu' element={<Mainmenu/>}/>
      <Route path='/createcustomer' element={<CreateCustomer/>}/>
    </Routes>
    </>
  );
}

export default App;
