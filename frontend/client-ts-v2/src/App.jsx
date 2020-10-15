import React, { useEffect} from 'react';
import './App.css';
import ClientList from './components/clientList';
import {getClients} from "./store/actions/clientsActions";
import { useDispatch } from 'react-redux';

function App() {
  const dispatch = useDispatch();
  
  useEffect(() => {
    dispatch(getClients());
  }, [dispatch]);
  return (
  <div className="App">
    <ClientList />
  </div>
    
  );
}

export default App;
