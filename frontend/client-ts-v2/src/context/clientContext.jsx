import React, {useState, useEffect} from 'react'
import axios from 'axios'

export const clientContext = React.createContext()

export const ClientProvider = (props) => {

    const [ clients, setClients ] = useState([ ]);

    useEffect( () => {
        axios.get('https://localhost:5001/Client')
        .then(response => {
          console.log(response);
          setClients(response.data.clients);
        })
        .catch(error => {
          console.log(error)
        })
      }, [])

      return(
          <clientContext.Provider value = {[clients]}>
              {props.children}
          </clientContext.Provider>
      )
}