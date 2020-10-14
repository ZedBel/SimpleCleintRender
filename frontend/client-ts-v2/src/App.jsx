import React from 'react';
import './App.css';
import ClientList from './componenets/clientList';
import { ClientProvider } from './context/clientContext';

function App() {
  return (
    
    <ClientProvider>
      <div className="App">
        <ClientList />
      </div>
    </ClientProvider>
    
  );
}

export default App;
