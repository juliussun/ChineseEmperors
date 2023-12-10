import { useEffect, useState } from "react";
import "./App.css";
import { BrowserRouter, Routes, Route } from "react-router-dom";
import CreateEmperor from "../component/CreateEmperor";
import Canvas from "../component/Canvas";
import Header from "../component/Header";

function App() {
  return (
    <BrowserRouter>
      <Header />
      <Routes>
        <Route path="/" element={<Canvas/>}/>
        <Route path="/createemperor" element={<CreateEmperor/>}/>

      </Routes>
    </BrowserRouter>
  );
}

export default App;
