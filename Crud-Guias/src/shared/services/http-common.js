import axios from "axios";

const API_BASE_URL = 'https://my-json-server.typicode.com/Turisteros-Ventures/db-server';
const http = axios.create({
    baseURL: API_BASE_URL, headers: {
        'Content-type': 'application/json',
    }
});

export default http;