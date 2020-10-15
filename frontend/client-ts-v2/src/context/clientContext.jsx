import React, {useState, useEffect} from 'react'
import axios from 'axios'

export const clientContext = React.createContext()

export const ClientProvider = (props) => {

    const [ clients, setClients ] = useState([ ]);
    

    useEffect(() => {
        (async () => {
            try {
                const api = await axios.get('https://localhost:5001/Client');
                setClients(api.data.clients);
            } catch (e){
                console.error(e);
            }
        })();
      },[])

      return(
          <clientContext.Provider value = {[clients]}>
              {props.children}
          </clientContext.Provider>
      )
}