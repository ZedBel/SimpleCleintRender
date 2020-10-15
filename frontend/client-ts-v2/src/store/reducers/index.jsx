import { combineReducers } from "redux";
import clientReducer from './clientsReducer';


export default combineReducers({
    clients: clientReducer
})