import { GET_CLIENTS } from '../types';

const initialState = {
    clients: [],
    loading: true
}

export default function(state = initialState, action){
    switch(action.type){
        case GET_CLIENTS:
            return{
                ...state,
                clients:action.payload,
                loading: false
            }
        default: return state
    }
}