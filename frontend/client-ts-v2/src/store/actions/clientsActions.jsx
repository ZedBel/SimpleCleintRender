import { GET_CLIENTS, CLIENTS_ERROR } from "../types";
import axios from "axios";

export const getClients = () => async dispatch => {
    try{
        const response = await axios.get('https://localhost:5001/clients')
        dispatch({
            type: GET_CLIENTS,
            payload: response.data.clients
        })
    }catch (e){
        dispatch({
            type: CLIENTS_ERROR,
            payload: console.log(e)
        })
    }
}