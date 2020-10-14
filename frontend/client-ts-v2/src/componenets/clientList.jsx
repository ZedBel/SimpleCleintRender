import React, { useContext } from 'react'
import { clientContext } from '../context/clientContext'
import Table from './Table'
import 'bootstrap/dist/css/bootstrap.min.css';

const ClientList = () =>{
    
    const [clients] = useContext(clientContext);

    return(
       

        <div className="card">
            <div className="card-header">
                Clients
            </div>
            <div className="card-body">
                <Table clients = {clients} />
            </div>
        </div>
    )
}

export default ClientList;