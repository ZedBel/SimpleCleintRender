import React from 'react'
import Table from './Table'
import 'bootstrap/dist/css/bootstrap.min.css';

const ClientList = () => {

    return(
        <div className="card">
            <div className="card-header">
                Clients
            </div>
            <div className="card-body">
                <Table  />
            </div>
        </div>
    )
}

export default ClientList;