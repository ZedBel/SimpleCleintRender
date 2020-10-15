import React, { useContext } from 'react';
import 'bootstrap/dist/css/bootstrap.min.css';
import { clientContext } from '../context/clientContext';

const Table = () => {
    const [clients] = useContext(clientContext);
    return(
        <table className="table">
            <thead>
                <tr>
                    <th>Id</th>
                    <th>Name</th>
                    <th>Age</th>
                </tr>
            </thead>
            <tbody>

               
            { (clients.length > 0) ? clients.map( (client, index) => {
            return (
                <tr key={ index }>
                <td><a href={ client.id }> { client.id } </a></td>
                <td>{ client.name }</td>
                <td>{ client.age }</td>
                </tr>
            )
            }) : <tr><td colSpan="3">Loading.....</td></tr> }
            </tbody>
        </table>
    );
}

export default Table;